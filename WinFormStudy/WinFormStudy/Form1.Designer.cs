namespace WinFormStudy
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
      this.label_name = new System.Windows.Forms.Label();
      this.textBox_name = new System.Windows.Forms.TextBox();
      this.button_showName = new System.Windows.Forms.Button();
      this.label_count = new System.Windows.Forms.Label();
      this.listBox_name = new System.Windows.Forms.ListBox();
      this.button_add = new System.Windows.Forms.Button();
      this.button_clear = new System.Windows.Forms.Button();
      this.button_nextForm = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label_name
      // 
      this.label_name.AutoSize = true;
      this.label_name.Location = new System.Drawing.Point(0, 10);
      this.label_name.Name = "label_name";
      this.label_name.Size = new System.Drawing.Size(53, 18);
      this.label_name.TabIndex = 0;
      this.label_name.Text = "Name:";
      // 
      // textBox_name
      // 
      this.textBox_name.Location = new System.Drawing.Point(104, 7);
      this.textBox_name.Name = "textBox_name";
      this.textBox_name.Size = new System.Drawing.Size(100, 28);
      this.textBox_name.TabIndex = 1;
      this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
      // 
      // button_showName
      // 
      this.button_showName.Location = new System.Drawing.Point(341, 1);
      this.button_showName.Name = "button_showName";
      this.button_showName.Size = new System.Drawing.Size(141, 34);
      this.button_showName.TabIndex = 2;
      this.button_showName.Text = "ShowYourName";
      this.button_showName.UseVisualStyleBackColor = true;
      this.button_showName.Click += new System.EventHandler(this.button_showName_Click);
      // 
      // label_count
      // 
      this.label_count.AutoSize = true;
      this.label_count.Location = new System.Drawing.Point(210, 10);
      this.label_count.Name = "label_count";
      this.label_count.Size = new System.Drawing.Size(80, 18);
      this.label_count.TabIndex = 3;
      this.label_count.Text = "Count: 0";
      // 
      // listBox_name
      // 
      this.listBox_name.FormattingEnabled = true;
      this.listBox_name.ItemHeight = 18;
      this.listBox_name.Location = new System.Drawing.Point(12, 57);
      this.listBox_name.Name = "listBox_name";
      this.listBox_name.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.listBox_name.Size = new System.Drawing.Size(161, 112);
      this.listBox_name.TabIndex = 4;
      // 
      // button_add
      // 
      this.button_add.Location = new System.Drawing.Point(213, 57);
      this.button_add.Name = "button_add";
      this.button_add.Size = new System.Drawing.Size(77, 38);
      this.button_add.TabIndex = 5;
      this.button_add.Text = "Add";
      this.button_add.UseVisualStyleBackColor = true;
      this.button_add.Click += new System.EventHandler(this.button1_Click);
      // 
      // button_clear
      // 
      this.button_clear.Location = new System.Drawing.Point(213, 101);
      this.button_clear.Name = "button_clear";
      this.button_clear.Size = new System.Drawing.Size(77, 36);
      this.button_clear.TabIndex = 6;
      this.button_clear.Text = "clear";
      this.button_clear.UseVisualStyleBackColor = true;
      this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
      // 
      // button_nextForm
      // 
      this.button_nextForm.Location = new System.Drawing.Point(471, 381);
      this.button_nextForm.Name = "button_nextForm";
      this.button_nextForm.Size = new System.Drawing.Size(138, 41);
      this.button_nextForm.TabIndex = 7;
      this.button_nextForm.Text = "Next Form";
      this.button_nextForm.UseVisualStyleBackColor = true;
      this.button_nextForm.Click += new System.EventHandler(this.button_nextForm_Click);
      // 
      // Form1
      // 
      this.AcceptButton = this.button_nextForm;
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(621, 448);
      this.Controls.Add(this.button_nextForm);
      this.Controls.Add(this.button_clear);
      this.Controls.Add(this.button_add);
      this.Controls.Add(this.listBox_name);
      this.Controls.Add(this.label_count);
      this.Controls.Add(this.button_showName);
      this.Controls.Add(this.textBox_name);
      this.Controls.Add(this.label_name);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label_name;
    private System.Windows.Forms.TextBox textBox_name;
    private System.Windows.Forms.Button button_showName;
    private System.Windows.Forms.Label label_count;
    private System.Windows.Forms.ListBox listBox_name;
    private System.Windows.Forms.Button button_add;
    private System.Windows.Forms.Button button_clear;
    private System.Windows.Forms.Button button_nextForm;
  }
}

