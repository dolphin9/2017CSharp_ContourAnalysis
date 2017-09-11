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
            AboutBox1 f1 = new AboutBox1();
            f1.Show();
        }

        private void IKnow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
