using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogFileViewer
{
    public partial class Form_FindReplace : Form
    {
        Form1 mainForm;
        private int findmode;
        public Form_FindReplace(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            FindMode_Normal.Checked = true;
            findmode = 1;
        }
        
        private void FindMode_CheckedChanged(object sender, EventArgs e)
        {
            switch(((RadioButton)sender).Text.ToString())
            {
                case "普通":
                    findmode = 1;
                    break;
                case "正则表达式":
                    findmode = 2;
                    break;
                default:
                    break;
            }
        }

        private void Button_FindNext_Click(object sender, EventArgs e)
        {
            mainForm.FindContent(this.TextBox_FindContent.Text, findmode);
        }

        private void Button_Replace_Click(object sender, EventArgs e)
        {
            mainForm.ReplaceContent(this.TextBox_ReplaceContent.Text);
        }

        private void Button_FindAll_Click(object sender, EventArgs e)
        {
            mainForm.FindContent_All(this.TextBox_FindContent.Text, findmode);
        }
    }
}
