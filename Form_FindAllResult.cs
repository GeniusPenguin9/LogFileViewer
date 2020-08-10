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
    public partial class Form_FindAllResult : Form
    {
        public Form_FindAllResult()
        {
            InitializeComponent();
        }
        public void ClearContent()
        {
            this.RichTextBox_FindAll.Clear();
        }

        public void AddOneLine(string s)
        {
            this.RichTextBox_FindAll.AppendText(s);
            this.RichTextBox_FindAll.AppendText("\r\n");
        }
    }
}
