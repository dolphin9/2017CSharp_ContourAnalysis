using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContourAnalysisDemo
{
    public partial class Tips : Form
    {
        private int RichTextBoxPage = 0;
        private int TotalPages = 4;
        private string[] RTFAddr = {
            "1.rtf","2.rtf","3.rtf","4.rtf"
        };

        public Tips()
        {
            InitializeComponent();
            //System.Reflection.Assembly app = System.Reflection.Assembly.GetExecutingAssembly();

            //string[] xx = app.GetManifestResourceNames();
            //System.IO.FileStream aa = app.GetFile("你的文本文件的名字");
            richTextBox1.LoadFile(RTFAddr[RichTextBoxPage], RichTextBoxStreamType.RichText);

        }

        private void LastPage_Click(object sender, EventArgs e)
        {
            RichTextBoxPage = (RichTextBoxPage + TotalPages - 1) % TotalPages;
            richTextBox1.LoadFile(RTFAddr[RichTextBoxPage], RichTextBoxStreamType.RichText);
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            RichTextBoxPage = (RichTextBoxPage + 1) % TotalPages;
            richTextBox1.LoadFile(RTFAddr[RichTextBoxPage], RichTextBoxStreamType.RichText);
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {

        }

        private void IKnow_Click(object sender, EventArgs e)
        {

        }
    }
}
