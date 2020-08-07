namespace LogFileViewer
{
    partial class Form_FindReplace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_FindContent = new System.Windows.Forms.TextBox();
            this.Label_FindContent = new System.Windows.Forms.Label();
            this.Button_FindNext = new System.Windows.Forms.Button();
            this.Button_FindAll = new System.Windows.Forms.Button();
            this.Button_Replace = new System.Windows.Forms.Button();
            this.FindMode_Normal = new System.Windows.Forms.RadioButton();
            this.FindMode_RegularExpression = new System.Windows.Forms.RadioButton();
            this.Group_FindMode = new System.Windows.Forms.GroupBox();
            this.TextBox_ReplaceContent = new System.Windows.Forms.TextBox();
            this.Label_ReplaceContent = new System.Windows.Forms.Label();
            this.Group_FindMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_FindContent
            // 
            this.TextBox_FindContent.Location = new System.Drawing.Point(133, 36);
            this.TextBox_FindContent.Name = "TextBox_FindContent";
            this.TextBox_FindContent.Size = new System.Drawing.Size(419, 21);
            this.TextBox_FindContent.TabIndex = 0;
            // 
            // Label_FindContent
            // 
            this.Label_FindContent.AutoSize = true;
            this.Label_FindContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_FindContent.Location = new System.Drawing.Point(40, 36);
            this.Label_FindContent.Name = "Label_FindContent";
            this.Label_FindContent.Size = new System.Drawing.Size(88, 16);
            this.Label_FindContent.TabIndex = 1;
            this.Label_FindContent.Text = "查找内容：";
            // 
            // Button_FindNext
            // 
            this.Button_FindNext.Location = new System.Drawing.Point(599, 33);
            this.Button_FindNext.Name = "Button_FindNext";
            this.Button_FindNext.Size = new System.Drawing.Size(135, 24);
            this.Button_FindNext.TabIndex = 2;
            this.Button_FindNext.Text = "查找下一个";
            this.Button_FindNext.UseVisualStyleBackColor = true;
            this.Button_FindNext.Click += new System.EventHandler(this.Button_FindNext_Click);
            // 
            // Button_FindAll
            // 
            this.Button_FindAll.Location = new System.Drawing.Point(599, 80);
            this.Button_FindAll.Name = "Button_FindAll";
            this.Button_FindAll.Size = new System.Drawing.Size(135, 24);
            this.Button_FindAll.TabIndex = 3;
            this.Button_FindAll.Text = "查找全部";
            this.Button_FindAll.UseVisualStyleBackColor = true;
            this.Button_FindAll.Click += new System.EventHandler(this.Button_FindAll_Click);
            // 
            // Button_Replace
            // 
            this.Button_Replace.Location = new System.Drawing.Point(599, 127);
            this.Button_Replace.Name = "Button_Replace";
            this.Button_Replace.Size = new System.Drawing.Size(135, 24);
            this.Button_Replace.TabIndex = 4;
            this.Button_Replace.Text = "替换";
            this.Button_Replace.UseVisualStyleBackColor = true;
            this.Button_Replace.Click += new System.EventHandler(this.Button_Replace_Click);
            // 
            // FindMode_Normal
            // 
            this.FindMode_Normal.AutoSize = true;
            this.FindMode_Normal.Location = new System.Drawing.Point(20, 32);
            this.FindMode_Normal.Name = "FindMode_Normal";
            this.FindMode_Normal.Size = new System.Drawing.Size(47, 16);
            this.FindMode_Normal.TabIndex = 5;
            this.FindMode_Normal.TabStop = true;
            this.FindMode_Normal.Text = "普通";
            this.FindMode_Normal.UseVisualStyleBackColor = true;
            this.FindMode_Normal.CheckedChanged += new System.EventHandler(this.FindMode_CheckedChanged);
            // 
            // FindMode_RegularExpression
            // 
            this.FindMode_RegularExpression.AutoSize = true;
            this.FindMode_RegularExpression.Location = new System.Drawing.Point(20, 67);
            this.FindMode_RegularExpression.Name = "FindMode_RegularExpression";
            this.FindMode_RegularExpression.Size = new System.Drawing.Size(83, 16);
            this.FindMode_RegularExpression.TabIndex = 6;
            this.FindMode_RegularExpression.TabStop = true;
            this.FindMode_RegularExpression.Text = "正则表达式";
            this.FindMode_RegularExpression.UseVisualStyleBackColor = true;
            this.FindMode_RegularExpression.CheckedChanged += new System.EventHandler(this.FindMode_CheckedChanged);
            // 
            // Group_FindMode
            // 
            this.Group_FindMode.Controls.Add(this.FindMode_Normal);
            this.Group_FindMode.Controls.Add(this.FindMode_RegularExpression);
            this.Group_FindMode.Location = new System.Drawing.Point(43, 177);
            this.Group_FindMode.Name = "Group_FindMode";
            this.Group_FindMode.Size = new System.Drawing.Size(200, 100);
            this.Group_FindMode.TabIndex = 7;
            this.Group_FindMode.TabStop = false;
            this.Group_FindMode.Text = "查找模式选择";
            // 
            // TextBox_ReplaceContent
            // 
            this.TextBox_ReplaceContent.Location = new System.Drawing.Point(133, 130);
            this.TextBox_ReplaceContent.Name = "TextBox_ReplaceContent";
            this.TextBox_ReplaceContent.Size = new System.Drawing.Size(419, 21);
            this.TextBox_ReplaceContent.TabIndex = 8;
            // 
            // Label_ReplaceContent
            // 
            this.Label_ReplaceContent.AutoSize = true;
            this.Label_ReplaceContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_ReplaceContent.Location = new System.Drawing.Point(40, 130);
            this.Label_ReplaceContent.Name = "Label_ReplaceContent";
            this.Label_ReplaceContent.Size = new System.Drawing.Size(88, 16);
            this.Label_ReplaceContent.TabIndex = 9;
            this.Label_ReplaceContent.Text = "替换内容：";
            // 
            // Form_FindReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 299);
            this.Controls.Add(this.Label_ReplaceContent);
            this.Controls.Add(this.TextBox_ReplaceContent);
            this.Controls.Add(this.Group_FindMode);
            this.Controls.Add(this.Button_Replace);
            this.Controls.Add(this.Button_FindAll);
            this.Controls.Add(this.Button_FindNext);
            this.Controls.Add(this.Label_FindContent);
            this.Controls.Add(this.TextBox_FindContent);
            this.Name = "Form_FindReplace";
            this.Text = "查找和替换";
            this.Group_FindMode.ResumeLayout(false);
            this.Group_FindMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_FindContent;
        private System.Windows.Forms.Label Label_FindContent;
        private System.Windows.Forms.Button Button_FindNext;
        private System.Windows.Forms.Button Button_FindAll;
        private System.Windows.Forms.Button Button_Replace;
        private System.Windows.Forms.RadioButton FindMode_Normal;
        private System.Windows.Forms.RadioButton FindMode_RegularExpression;
        private System.Windows.Forms.GroupBox Group_FindMode;
        private System.Windows.Forms.TextBox TextBox_ReplaceContent;
        private System.Windows.Forms.Label Label_ReplaceContent;
    }
}