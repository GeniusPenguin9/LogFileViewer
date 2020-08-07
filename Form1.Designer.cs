namespace LogFileViewer
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_New = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Find = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Replace = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayPositionBar = new System.Windows.Forms.TrackBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPositionBar)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(2, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(1292, 698);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Edit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1295, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_New,
            this.Menu_Open,
            this.Menu_Save,
            this.Menu_SaveAs,
            this.Menu_Exit});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(44, 21);
            this.Menu_File.Text = "文件";
            // 
            // Menu_New
            // 
            this.Menu_New.Name = "Menu_New";
            this.Menu_New.Size = new System.Drawing.Size(112, 22);
            this.Menu_New.Text = "新建";
            this.Menu_New.Click += new System.EventHandler(this.Menu_New_Click);
            // 
            // Menu_Open
            // 
            this.Menu_Open.Name = "Menu_Open";
            this.Menu_Open.Size = new System.Drawing.Size(112, 22);
            this.Menu_Open.Text = "打开";
            this.Menu_Open.Click += new System.EventHandler(this.Menu_Open_Click);
            // 
            // Menu_Save
            // 
            this.Menu_Save.Name = "Menu_Save";
            this.Menu_Save.Size = new System.Drawing.Size(112, 22);
            this.Menu_Save.Text = "保存";
            this.Menu_Save.Click += new System.EventHandler(this.Menu_Save_Click);
            // 
            // Menu_SaveAs
            // 
            this.Menu_SaveAs.Name = "Menu_SaveAs";
            this.Menu_SaveAs.Size = new System.Drawing.Size(112, 22);
            this.Menu_SaveAs.Text = "另存为";
            this.Menu_SaveAs.Click += new System.EventHandler(this.Menu_SaveAs_Click);
            // 
            // Menu_Exit
            // 
            this.Menu_Exit.Name = "Menu_Exit";
            this.Menu_Exit.Size = new System.Drawing.Size(112, 22);
            this.Menu_Exit.Text = "退出";
            this.Menu_Exit.Click += new System.EventHandler(this.Menu_Exit_Click);
            // 
            // Menu_Edit
            // 
            this.Menu_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Undo,
            this.Menu_Cut,
            this.Menu_Copy,
            this.Menu_Paste,
            this.Menu_Find,
            this.Menu_Replace});
            this.Menu_Edit.Name = "Menu_Edit";
            this.Menu_Edit.Size = new System.Drawing.Size(44, 21);
            this.Menu_Edit.Text = "编辑";
            // 
            // Menu_Undo
            // 
            this.Menu_Undo.Name = "Menu_Undo";
            this.Menu_Undo.Size = new System.Drawing.Size(180, 22);
            this.Menu_Undo.Text = "撤消(&Z)";
            this.Menu_Undo.Click += new System.EventHandler(this.Menu_Undo_Click);
            // 
            // Menu_Cut
            // 
            this.Menu_Cut.Name = "Menu_Cut";
            this.Menu_Cut.Size = new System.Drawing.Size(180, 22);
            this.Menu_Cut.Text = "剪切(&X)";
            this.Menu_Cut.Click += new System.EventHandler(this.Menu_Cut_Click);
            // 
            // Menu_Copy
            // 
            this.Menu_Copy.Name = "Menu_Copy";
            this.Menu_Copy.Size = new System.Drawing.Size(180, 22);
            this.Menu_Copy.Text = "复制(&C)";
            this.Menu_Copy.Click += new System.EventHandler(this.Menu_Copy_Click);
            // 
            // Menu_Paste
            // 
            this.Menu_Paste.Name = "Menu_Paste";
            this.Menu_Paste.Size = new System.Drawing.Size(180, 22);
            this.Menu_Paste.Text = "粘贴(&V)";
            this.Menu_Paste.Click += new System.EventHandler(this.Menu_Paste_Click);
            // 
            // Menu_Find
            // 
            this.Menu_Find.Name = "Menu_Find";
            this.Menu_Find.Size = new System.Drawing.Size(180, 22);
            this.Menu_Find.Text = "查找(&F)";
            this.Menu_Find.Click += new System.EventHandler(this.Menu_Find_Click);
            // 
            // Menu_Replace
            // 
            this.Menu_Replace.Name = "Menu_Replace";
            this.Menu_Replace.Size = new System.Drawing.Size(180, 22);
            this.Menu_Replace.Text = "替换(&H)";
            this.Menu_Replace.Click += new System.EventHandler(this.Menu_Replace_Click);
            // 
            // DisplayPositionBar
            // 
            this.DisplayPositionBar.AutoSize = false;
            this.DisplayPositionBar.Location = new System.Drawing.Point(1011, -1);
            this.DisplayPositionBar.Maximum = 100;
            this.DisplayPositionBar.Name = "DisplayPositionBar";
            this.DisplayPositionBar.Size = new System.Drawing.Size(283, 26);
            this.DisplayPositionBar.TabIndex = 3;
            this.DisplayPositionBar.Scroll += new System.EventHandler(this.DisplayPositionBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 732);
            this.Controls.Add(this.DisplayPositionBar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPositionBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem Menu_New;
        private System.Windows.Forms.ToolStripMenuItem Menu_Open;
        private System.Windows.Forms.ToolStripMenuItem Menu_Save;
        private System.Windows.Forms.ToolStripMenuItem Menu_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem Menu_Exit;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit;
        private System.Windows.Forms.ToolStripMenuItem Menu_Undo;
        private System.Windows.Forms.ToolStripMenuItem Menu_Cut;
        private System.Windows.Forms.ToolStripMenuItem Menu_Copy;
        private System.Windows.Forms.ToolStripMenuItem Menu_Paste;
        private System.Windows.Forms.ToolStripMenuItem Menu_Find;
        private System.Windows.Forms.ToolStripMenuItem Menu_Replace;
        private System.Windows.Forms.TrackBar DisplayPositionBar;
    }
}

