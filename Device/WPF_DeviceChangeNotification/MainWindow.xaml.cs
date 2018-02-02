﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DeviceChangeNotification
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IntPtr m_hNotifyDevNode;

        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);
            HwndSource source = PresentationSource.FromVisual(this) as HwndSource;
            source.AddHook(WndProc);

            Guid hidGuid = new Guid("4d1e55b2-f16f-11cf-88cb-001111000030");
            Guid usbXpressGuid = new Guid("3c5e1462-5695-4e18-876b-f3f3d08aaf18");
            Guid cp210xGuid = new Guid("993f7832-6e2d-4a0f-b272-e2c78e74f93e");
            Guid newCP210xGuid = new Guid("a2a39220-39f4-4b88-aecb-3d86a35dc748");

            RegisterNotification(hidGuid);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            UnregisterNotification();
        }

        private void RegisterNotification(Guid guid)
        {
            Dbt.DEV_BROADCAST_DEVICEINTERFACE devIF = new Dbt.DEV_BROADCAST_DEVICEINTERFACE();
            IntPtr devIFBuffer;

            // Set to HID GUID
            devIF.dbcc_size = Marshal.SizeOf(devIF);
            devIF.dbcc_devicetype = Dbt.DBT_DEVTYP_DEVICEINTERFACE;
            devIF.dbcc_reserved = 0;
            devIF.dbcc_classguid = guid;

            // Allocate a buffer for DLL call
            devIFBuffer = Marshal.AllocHGlobal(devIF.dbcc_size);

            // Copy devIF to buffer
            Marshal.StructureToPtr(devIF, devIFBuffer, true);

            // Register for HID device notifications
            m_hNotifyDevNode = Dbt.RegisterDeviceNotification((new WindowInteropHelper(this)).Handle, devIFBuffer, Dbt.DEVICE_NOTIFY_WINDOW_HANDLE);

            // Copy buffer to devIF
            Marshal.PtrToStructure(devIFBuffer, devIF);

            // Free buffer
            Marshal.FreeHGlobal(devIFBuffer);
        }

        // Unregister HID device notification
        private void UnregisterNotification()
        {
            uint ret = Dbt.UnregisterDeviceNotification(m_hNotifyDevNode);
        }

        protected IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            // Intercept the WM_DEVICECHANGE message
            if (msg == Dbt.WM_DEVICECHANGE)
            {
                // Get the message event type
                int nEventType = wParam.ToInt32();

                // Check for devices being connected or disconnected
                if (nEventType == Dbt.DBT_DEVICEARRIVAL ||
                    nEventType == Dbt.DBT_DEVICEREMOVECOMPLETE)
                {
                    Dbt.DEV_BROADCAST_HDR hdr = new Dbt.DEV_BROADCAST_HDR();

                    // Convert lparam to DEV_BROADCAST_HDR structure
                    Marshal.PtrToStructure(lParam, hdr);

                    if (hdr.dbch_devicetype == Dbt.DBT_DEVTYP_DEVICEINTERFACE)
                    {
                        Dbt.DEV_BROADCAST_DEVICEINTERFACE_1 devIF = new Dbt.DEV_BROADCAST_DEVICEINTERFACE_1();

                        // Convert lparam to DEV_BROADCAST_DEVICEINTERFACE structure
                        Marshal.PtrToStructure(lParam, devIF);

                        // Get the device path from the broadcast message
                        string devicePath = new string(devIF.dbcc_name);

                        // Remove null-terminated data from the string
                        int pos = devicePath.IndexOf((char)0);
                        if (pos != -1)
                        {
                            devicePath = devicePath.Substring(0, pos);
                        }

                        // An HID device was connected or removed
                        if (nEventType == Dbt.DBT_DEVICEREMOVECOMPLETE)
                        {
                            MessageBox.Show("Device \"" + devicePath + "\" was removed");
                        }
                        else if (nEventType == Dbt.DBT_DEVICEARRIVAL)
                        {
                            MessageBox.Show("Device \"" + devicePath + "\" arrived");
                        }
                    }
                }
            }
            return IntPtr.Zero;
        }

    }
}
