using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.MemoryMappedFiles;

namespace LogFileViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private string curfilename = "";
        private int find_position = 0;

        private void Menu_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Menu_New_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            curfilename = "";
            this.Text = "无标题";
        }

        private void Menu_Open_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "日志文件|*.txt";
            openFileDialog.InitialDirectory = "D:\\LindsayWang\\Git Repository NAS\\LogFileViewer\\TestFile";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                curfilename = openFileDialog.FileName;
                //richTextBox1.LoadFile(curfilename, RichTextBoxStreamType.PlainText);//直接读取的方法会在大文件卡住
                long offset = 0x10000000;
                long length = 0x20000000;
                var mmap = MemoryMappedFile.CreateFromFile(curfilename, FileMode.Open, "MMAP");
                var accessor = mmap.CreateViewAccessor(offset, length);
                //todo



                this.Text = curfilename;
            }
        }

        private void Menu_Save_Click(object sender, EventArgs e)
        {
            if (curfilename.Length > 0)
            {
                richTextBox1.SaveFile(curfilename, RichTextBoxStreamType.PlainText);

            }
            else
                Menu_SaveAs_Click(sender, e);
        }

        private void Menu_SaveAs_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "日志文件|*.txt";
            saveFileDialog.InitialDirectory = "D:\\";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                curfilename = saveFileDialog.FileName;
                richTextBox1.SaveFile(curfilename, RichTextBoxStreamType.PlainText);
                this.Text = curfilename.Split('\\').Last();
            }
        }

        private void Menu_Undo_Click(object sender, EventArgs e)
        {
            if(richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
                richTextBox1.ClearUndo();
            }
        }

        private void Menu_Cut_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
                richTextBox1.Cut();
        }

        private void Menu_Copy_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
                richTextBox1.Copy();
        }

        private void Menu_Paste_Click(object sender, EventArgs e)
        {
            if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                richTextBox1.Paste();
            }
        }

        private void Menu_Find_Click(object sender, EventArgs e)
        {
            var findReplaceDialog = new Form_FindReplace(this);
            findReplaceDialog.Show();
        }

        private void Menu_Replace_Click(object sender, EventArgs e)
        {
            Menu_Find_Click(sender, e);
        }

        /* ******************************************************* */
        public void FindContent(string target_content, int findmode)
        {
            var start_find_position = find_position;
            

            if(find_position >= richTextBox1.Text.Length)
            {
                find_position = 0;
            }

            if (findmode == 1)
                find_position = richTextBox1.Find(target_content, find_position, RichTextBoxFinds.MatchCase);
            else if (findmode == 2)
            {
                //todo
            }
            else
                return;

            if(find_position == -1)
            {
                MessageBox.Show("");
                find_position = 0;
            }
            else
            {
                richTextBox1.Focus();
                find_position += target_content.Length;
            }
        }

        public void ReplaceContent(string replace_s)
        {
            if (richTextBox1.SelectedText.Length != 0)
                richTextBox1.SelectedText = replace_s; 
        }
    }
}
