using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_AsyncThreadDemo
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnTask1_Click(object sender, EventArgs e)
    {
      int res = 0;
      Thread objThread1 = new Thread(delegate () {  //()=>
        for(int i=0;i<20;i++)
        {
          Console.WriteLine("Task1: "+(res+i + 10) + " ");
          res += i;
          if(lbTask1_res.InvokeRequired)
          {
            lbTask1_res.Invoke(new Action(() => this.lbTask1_res.Text = res.ToString()));
          }
          Thread.Sleep(1000);
        }
      });
      objThread1.IsBackground = true;
      objThread1.Start();
    }

    private void btnTask2_Click(object sender, EventArgs e)
    {
      int res = 0;
      Thread objThread2 = new Thread(() => {
        for(int i=0;i<50;i++)
        {
          Console.WriteLine("Task2: " + (res+i));
          res += i;
          Thread.Sleep(1000);
          if(lbTask2_res.InvokeRequired)
          {
            lbTask2_res.Invoke(new Action<string>(s => this.lbTask2_res.Text = s), res.ToString());
          }
        }
      });
      objThread2.IsBackground = true;
      objThread2.Start();
    }
  }
}
