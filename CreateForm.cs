using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FileCenter0
{
    public partial class CreateForm : Form
    {
        private string dirPath = string.Empty;
        public CreateForm(string path)
        {
            InitializeComponent();
            
            dirPath = path;
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            string q = string.Empty;
            int ct = DateTime.Now.Month;
            if (1 <= ct && ct <= 3) { q = "A"; }
            if (4 <= ct && ct <= 6) { q = "B"; }
            if (7 <= ct && ct <= 9) { q = "C"; }
            if (10 <= ct && ct <= 12) { q = "D"; }
            ht.Text = string.Format("{0}{1}_", DateTime.Now.Year % 100, q);

            reset_Click(sender, e);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            folderList.Text = string.Empty;

            string[] files = Directory.GetFiles(dirPath, "*" + type.Text);
            foreach (string fn in files)
            {
                string buf = Path.GetFileName(fn).Substring(9).Replace(type.Text, string.Empty);
                if (0 < buf.IndexOf('[')) { buf = buf.Substring(0, buf.IndexOf('[')); }
                if (0 < buf.IndexOf("「")) { buf = buf.Substring(0, buf.IndexOf("「")); }
                if (0 < buf.IndexOf("＃")) { buf = buf.Substring(0, buf.IndexOf("＃")); }
                folderList.Text += string.Format("{1}{0}\r\n", buf, ht.Text);
            }
            if (2 <= folderList.Text.Length)
            {
                folderList.Text = folderList.Text.Substring(0, folderList.Text.Length - 2);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            foreach (string dn in folderList.Text.Split("\r\n".ToCharArray()))
            {
                if (0 < dn.Length)
                {
                    Directory.CreateDirectory(string.Format("{0}\\{1}", dirPath, dn));
                    cnt++;
                }
            }
            MessageBox.Show(string.Format("{0}件のフォルダを作成しました。", cnt));
        }
    }
}