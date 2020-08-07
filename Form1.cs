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
        private long display_position = 0;
        private int find_position = 0;
        private long file_size = 0;
        private FileStream fs;
        private const int DISPLAY_SIZE = 1000;
        private byte[] display_buffer = new byte[DISPLAY_SIZE];

        //private MemoryMappedFile mmap;
        //private MemoryMappedViewAccessor accessor;
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
                FileInfo fi = new FileInfo(curfilename);
                file_size = fi.Length;

                //try
                //{
                //    mmap.Dispose();
                //}
                //catch(System.NullReferenceException) {  };

                ////richTextBox1.LoadFile(curfilename, RichTextBoxStreamType.PlainText);//直接读取的方法会在大文件卡住


                //mmap = MemoryMappedFile.CreateFromFile(curfilename, FileMode.Open, "MMAP");
                //accessor = mmap.CreateViewAccessor();
                OpenFileStream(curfilename);
                int read_byte = LoadFile_Display();
                RefreshDisplayContent(read_byte);

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

        private void DisplayPositionBar_Scroll(object sender, EventArgs e)
        {
            display_position = DisplayPositionBar.Value * file_size / 100;
            int read_byte = LoadFile_Display();
            RefreshDisplayContent(read_byte);
        }

        /* ******************************************************* */
        public void FindContent(string target_content, int findmode)
        {
            var find_length = 0;
            
            while (find_length <= file_size)
            {
                if (findmode == 1)
                    find_position = richTextBox1.Find(target_content, find_position, RichTextBoxFinds.MatchCase);
                else if (findmode == 2)
                {
                    //todo
                }
                else
                    MessageBox.Show("搜索模式异常！");

                if (find_position != -1)
                {
                    richTextBox1.Focus();
                    find_position += target_content.Length;
                    DisplayPositionBar_SetValue(display_position + find_position);
                    return;
                }
                else
                {
                    //刷新成下一页
                    display_position += DISPLAY_SIZE;
                    find_position = 0;

                    if (display_position >= file_size)
                         display_position = 0;
                    int read_byte = LoadFile_Display();
                    RefreshDisplayContent(read_byte);
                    find_length += read_byte;
                }
            }
            MessageBox.Show("已搜索全文，未找到内容!");
        }

        public void FindContent_All(Form_FindReplace resultForm)
        {
            //fs.Seek(0, SeekOrigin.Begin);
            //while(fs.Length <= fs.Length)
            //{
            //    fs.Read()
            //}
        }

        public void ReplaceContent(string replace_s)
        {
            if (richTextBox1.SelectedText.Length != 0)
                richTextBox1.SelectedText = replace_s; 
        }

        private  void RefreshDisplayContent (int buffer_len)
        {
            //accessor.ReadArray(position, display_buffer, 0, DISPLAY_SIZE);

            this.richTextBox1.Text = Encoding.ASCII.GetString(display_buffer, 0, buffer_len);     
        }
        private void OpenFileStream(string path)
        {
            if (fs == null)
                fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            else
            {
                fs.Dispose();
                fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            }
            display_position = 0;
        }
        private int LoadFile_Display()
        {
            fs.Seek(display_position, SeekOrigin.Begin);
            int read_byte = fs.Read(display_buffer, 0, DISPLAY_SIZE);
            return read_byte;
        }

        private void DisplayPositionBar_SetValue(long value)
        {
            this.DisplayPositionBar.Value = (int)(100 * value / file_size);
        }
    }
}
