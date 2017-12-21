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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.label_name = new System.Windows.Forms.Label();
      this.textBox_name = new System.Windows.Forms.TextBox();
      this.button_showName = new System.Windows.Forms.Button();
      this.label_count = new System.Windows.Forms.Label();
      this.listBox_name = new System.Windows.Forms.ListBox();
      this.button_add = new System.Windows.Forms.Button();
      this.button_clear = new System.Windows.Forms.Button();
      this.button_nextForm = new System.Windows.Forms.Button();
      this.menuStrip_file = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.item1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.i1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.i2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.item2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.item3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.menuStrip_file.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label_name
      // 
      this.label_name.AutoSize = true;
      this.label_name.Location = new System.Drawing.Point(4, 53);
      this.label_name.Name = "label_name";
      this.label_name.Size = new System.Drawing.Size(53, 18);
      this.label_name.TabIndex = 0;
      this.label_name.Text = "Name:";
      // 
      // textBox_name
      // 
      this.textBox_name.Location = new System.Drawing.Point(108, 50);
      this.textBox_name.Name = "textBox_name";
      this.textBox_name.Size = new System.Drawing.Size(100, 28);
      this.textBox_name.TabIndex = 1;
      this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
      // 
      // button_showName
      // 
      this.button_showName.Location = new System.Drawing.Point(345, 44);
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
      this.label_count.Location = new System.Drawing.Point(214, 53);
      this.label_count.Name = "label_count";
      this.label_count.Size = new System.Drawing.Size(80, 18);
      this.label_count.TabIndex = 3;
      this.label_count.Text = "Count: 0";
      // 
      // listBox_name
      // 
      this.listBox_name.FormattingEnabled = true;
      this.listBox_name.ItemHeight = 18;
      this.listBox_name.Location = new System.Drawing.Point(16, 100);
      this.listBox_name.Name = "listBox_name";
      this.listBox_name.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.listBox_name.Size = new System.Drawing.Size(161, 112);
      this.listBox_name.TabIndex = 4;
      // 
      // button_add
      // 
      this.button_add.Location = new System.Drawing.Point(217, 100);
      this.button_add.Name = "button_add";
      this.button_add.Size = new System.Drawing.Size(77, 38);
      this.button_add.TabIndex = 5;
      this.button_add.Text = "Add";
      this.button_add.UseVisualStyleBackColor = true;
      this.button_add.Click += new System.EventHandler(this.button1_Click);
      // 
      // button_clear
      // 
      this.button_clear.Location = new System.Drawing.Point(217, 144);
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
      // menuStrip_file
      // 
      this.menuStrip_file.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip_file.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
      this.menuStrip_file.Location = new System.Drawing.Point(0, 0);
      this.menuStrip_file.Name = "menuStrip_file";
      this.menuStrip_file.Size = new System.Drawing.Size(621, 33);
      this.menuStrip_file.TabIndex = 8;
      this.menuStrip_file.Text = "menuStrip1";
      this.menuStrip_file.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_file_ItemClicked);
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
      this.fileToolStripMenuItem.Text = "File";
      this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openToolStripMenuItem.Size = new System.Drawing.Size(202, 30);
      this.openToolStripMenuItem.Text = "open";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
      // 
      // closeToolStripMenuItem
      // 
      this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
      this.closeToolStripMenuItem.Size = new System.Drawing.Size(202, 30);
      this.closeToolStripMenuItem.Text = "Exit";
      this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
      this.editToolStripMenuItem.Text = "Edit";
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.item2ToolStripMenuItem,
            this.item3ToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(130, 94);
      // 
      // item1ToolStripMenuItem
      // 
      this.item1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i1ToolStripMenuItem,
            this.i2ToolStripMenuItem});
      this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
      this.item1ToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
      this.item1ToolStripMenuItem.Text = "item1";
      // 
      // i1ToolStripMenuItem
      // 
      this.i1ToolStripMenuItem.Name = "i1ToolStripMenuItem";
      this.i1ToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
      this.i1ToolStripMenuItem.Text = "i1";
      // 
      // i2ToolStripMenuItem
      // 
      this.i2ToolStripMenuItem.Name = "i2ToolStripMenuItem";
      this.i2ToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
      this.i2ToolStripMenuItem.Text = "i2";
      // 
      // item2ToolStripMenuItem
      // 
      this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
      this.item2ToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
      this.item2ToolStripMenuItem.Text = "item2";
      // 
      // item3ToolStripMenuItem
      // 
      this.item3ToolStripMenuItem.Name = "item3ToolStripMenuItem";
      this.item3ToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
      this.item3ToolStripMenuItem.Text = "item3";
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
      this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
      this.notifyIcon1.Text = "WinformEXE";
      this.notifyIcon1.Visible = true;
      // 
      // Form1
      // 
      this.AcceptButton = this.button_nextForm;
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(621, 448);
      this.ContextMenuStrip = this.contextMenuStrip1;
      this.Controls.Add(this.button_nextForm);
      this.Controls.Add(this.button_clear);
      this.Controls.Add(this.button_add);
      this.Controls.Add(this.listBox_name);
      this.Controls.Add(this.label_count);
      this.Controls.Add(this.button_showName);
      this.Controls.Add(this.textBox_name);
      this.Controls.Add(this.label_name);
      this.Controls.Add(this.menuStrip_file);
      this.MainMenuStrip = this.menuStrip_file;
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip_file.ResumeLayout(false);
      this.menuStrip_file.PerformLayout();
      this.contextMenuStrip1.ResumeLayout(false);
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
    private System.Windows.Forms.MenuStrip menuStrip_file;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem item1ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem i1ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem i2ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem item2ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem item3ToolStripMenuItem;
    private System.Windows.Forms.NotifyIcon notifyIcon1;
  }
}

