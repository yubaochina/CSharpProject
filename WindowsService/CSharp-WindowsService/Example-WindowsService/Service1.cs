using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Example_WindowsService
{
  public partial class Service1 : ServiceBase
  {
    public Service1()
    {
      InitializeComponent();
    }
    public void OnDebug()
    {
      OnStart(null);
    }

    protected override void OnStart(string[] args)
    {
    //  System.IO.File.Create(Environment.CurrentDirectory + "OnStart.txt"); //System32
      System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "OnStart.txt");
    }

    protected override void OnStop()
    {
      System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "OnStop.txt");
    }
  }
}
