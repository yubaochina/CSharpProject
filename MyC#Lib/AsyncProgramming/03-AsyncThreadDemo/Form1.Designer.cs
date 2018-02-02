namespace _03_AsyncThreadDemo
{
  partial class Form1
  {
    /// <summary>
    /// 必需的设计器变量。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清理所有正在使用的资源。
    /// </summary>
    /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows 窗体设计器生成的代码

    /// <summary>
    /// 设计器支持所需的方法 - 不要修改
    /// 使用代码编辑器修改此方法的内容。
    /// </summary>
    private void InitializeComponent()
    {
      this.btnTask1 = new System.Windows.Forms.Button();
      this.btnTask2 = new System.Windows.Forms.Button();
      this.lbTask1_res = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lbTask2_res = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnTask1
      // 
      this.btnTask1.Location = new System.Drawing.Point(174, 198);
      this.btnTask1.Name = "btnTask1";
      this.btnTask1.Size = new System.Drawing.Size(103, 44);
      this.btnTask1.TabIndex = 0;
      this.btnTask1.Text = "Task1";
      this.btnTask1.UseVisualStyleBackColor = true;
      this.btnTask1.Click += new System.EventHandler(this.btnTask1_Click);
      // 
      // btnTask2
      // 
      this.btnTask2.Location = new System.Drawing.Point(408, 198);
      this.btnTask2.Name = "btnTask2";
      this.btnTask2.Size = new System.Drawing.Size(91, 44);
      this.btnTask2.TabIndex = 1;
      this.btnTask2.Text = "Task2";
      this.btnTask2.UseVisualStyleBackColor = true;
      this.btnTask2.Click += new System.EventHandler(this.btnTask2_Click);
      // 
      // lbTask1_res
      // 
      this.lbTask1_res.AutoSize = true;
      this.lbTask1_res.Location = new System.Drawing.Point(290, 39);
      this.lbTask1_res.Name = "lbTask1_res";
      this.lbTask1_res.Size = new System.Drawing.Size(44, 18);
      this.lbTask1_res.TabIndex = 2;
      this.lbTask1_res.Text = "null";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(161, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(125, 18);
      this.label2.TabIndex = 3;
      this.label2.Text = "Task1 Result:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(161, 101);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(125, 18);
      this.label3.TabIndex = 4;
      this.label3.Text = "Task2 Result:";
      // 
      // lbTask2_res
      // 
      this.lbTask2_res.AutoSize = true;
      this.lbTask2_res.Location = new System.Drawing.Point(290, 101);
      this.lbTask2_res.Name = "lbTask2_res";
      this.lbTask2_res.Size = new System.Drawing.Size(44, 18);
      this.lbTask2_res.TabIndex = 5;
      this.lbTask2_res.Text = "null";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(700, 360);
      this.Controls.Add(this.lbTask2_res);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lbTask1_res);
      this.Controls.Add(this.btnTask2);
      this.Controls.Add(this.btnTask1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnTask1;
    private System.Windows.Forms.Button btnTask2;
    private System.Windows.Forms.Label lbTask1_res;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lbTask2_res;
  }
}

