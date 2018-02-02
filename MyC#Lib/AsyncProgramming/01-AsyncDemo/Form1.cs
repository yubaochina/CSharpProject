using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncProgramming
{


  public partial class Form1 : Form
  {
    public delegate int MyAyncCalculate_delagage(int num);

    public Form1()
    {
      InitializeComponent();
    }

    private void btnSynchronous_Click(object sender, EventArgs e)
    {
      lbSync_count1.Text = task1(10).ToString();
      lbSync_count2.Text = task2(10).ToString();
    }

    private int task1(int num)
    {
      System.Threading.Thread.Sleep(5000);
      return num * num;
    }
    private int task2(int num)
    {
      return num * num;
    }

    private void btnAsynchronous_Click(object sender, EventArgs e)
    {
      MyAyncCalculate_delagage ObjAync = task1;

      IAsyncResult asyncResult = ObjAync.BeginInvoke(10, null, null);
      this.lbAsync_count1.Text = "Calculating";

      this.lbAsync_count2.Text = task2(10).ToString();

      int res = ObjAync.EndInvoke(asyncResult);
      this.lbAsync_count1.Text = res.ToString();
    }
  }
}
