namespace AsyncProgramming
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
      this.btnSynchronous = new System.Windows.Forms.Button();
      this.btnAsynchronous = new System.Windows.Forms.Button();
      this.lbSync_count1 = new System.Windows.Forms.Label();
      this.lbSync_count2 = new System.Windows.Forms.Label();
      this.lbAsync_count1 = new System.Windows.Forms.Label();
      this.lbAsync_count2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnSynchronous
      // 
      this.btnSynchronous.Location = new System.Drawing.Point(145, 234);
      this.btnSynchronous.Name = "btnSynchronous";
      this.btnSynchronous.Size = new System.Drawing.Size(122, 40);
      this.btnSynchronous.TabIndex = 0;
      this.btnSynchronous.Text = "synchronous";
      this.btnSynchronous.UseVisualStyleBackColor = true;
      this.btnSynchronous.Click += new System.EventHandler(this.btnSynchronous_Click);
      // 
      // btnAsynchronous
      // 
      this.btnAsynchronous.Location = new System.Drawing.Point(393, 234);
      this.btnAsynchronous.Name = "btnAsynchronous";
      this.btnAsynchronous.Size = new System.Drawing.Size(141, 40);
      this.btnAsynchronous.TabIndex = 1;
      this.btnAsynchronous.Text = "asynchronous";
      this.btnAsynchronous.UseVisualStyleBackColor = true;
      this.btnAsynchronous.Click += new System.EventHandler(this.btnAsynchronous_Click);
      // 
      // lbSync_count1
      // 
      this.lbSync_count1.AutoSize = true;
      this.lbSync_count1.Location = new System.Drawing.Point(145, 114);
      this.lbSync_count1.Name = "lbSync_count1";
      this.lbSync_count1.Size = new System.Drawing.Size(17, 18);
      this.lbSync_count1.TabIndex = 2;
      this.lbSync_count1.Text = "0";
      // 
      // lbSync_count2
      // 
      this.lbSync_count2.AutoSize = true;
      this.lbSync_count2.Location = new System.Drawing.Point(145, 177);
      this.lbSync_count2.Name = "lbSync_count2";
      this.lbSync_count2.Size = new System.Drawing.Size(17, 18);
      this.lbSync_count2.TabIndex = 3;
      this.lbSync_count2.Text = "0";
      // 
      // lbAsync_count1
      // 
      this.lbAsync_count1.AutoSize = true;
      this.lbAsync_count1.Location = new System.Drawing.Point(390, 105);
      this.lbAsync_count1.Name = "lbAsync_count1";
      this.lbAsync_count1.Size = new System.Drawing.Size(17, 18);
      this.lbAsync_count1.TabIndex = 4;
      this.lbAsync_count1.Text = "0";
      // 
      // lbAsync_count2
      // 
      this.lbAsync_count2.AutoSize = true;
      this.lbAsync_count2.Location = new System.Drawing.Point(390, 177);
      this.lbAsync_count2.Name = "lbAsync_count2";
      this.lbAsync_count2.Size = new System.Drawing.Size(17, 18);
      this.lbAsync_count2.TabIndex = 5;
      this.lbAsync_count2.Text = "0";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(688, 364);
      this.Controls.Add(this.lbAsync_count2);
      this.Controls.Add(this.lbAsync_count1);
      this.Controls.Add(this.lbSync_count2);
      this.Controls.Add(this.lbSync_count1);
      this.Controls.Add(this.btnAsynchronous);
      this.Controls.Add(this.btnSynchronous);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnSynchronous;
    private System.Windows.Forms.Button btnAsynchronous;
    private System.Windows.Forms.Label lbSync_count1;
    private System.Windows.Forms.Label lbSync_count2;
    private System.Windows.Forms.Label lbAsync_count1;
    private System.Windows.Forms.Label lbAsync_count2;
  }
}

