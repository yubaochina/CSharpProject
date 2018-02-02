using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_AsyncCallbackDemo
{
  public partial class Form1 : Form
  {
    MyCalculator_d objCalculator_d = null;
    public Form1()
    {
      InitializeComponent();
      this.objCalculator_d = (int num, int delay_ms) =>
      {
        System.Threading.Thread.Sleep(delay_ms);
        return num * num;
      };
    }
    public delegate int MyCalculator_d(int num, int delay_ms);
     
    //private int ExecTask(int num, int delay_ms)
    //{
    //  System.Threading.Thread.Sleep(delay_ms);
    //  return num * num;
    //}

    private void MyCallback(IAsyncResult result)
    {
      int res = objCalculator_d.EndInvoke(result);
      Console.WriteLine("Task {0} => {1}", result.AsyncState.ToString(), res);
    }

    private void btMultiTask_Click(object sender, EventArgs e)
    {

      for(int i=1;i<11;i++)
      {
        objCalculator_d.BeginInvoke(10 * i, 1000 * i, MyCallback, i);
      }
    }
  }
}
