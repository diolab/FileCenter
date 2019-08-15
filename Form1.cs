using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FileCenter0
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private const int TOPLENGTH = 19;

        private void MainForm_Load(object sender, EventArgs e)
        {
            path.Text = System.Environment.CurrentDirectory;

            for (int y = -1; y < 2; y++)
            {
                topText.Items.Add(string.Format("{0}D_", DateTime.Now.Year % 100 - y));
                topText.Items.Add(string.Format("{0}C_", DateTime.Now.Year % 100 - y));
                topText.Items.Add(string.Format("{0}B_", DateTime.Now.Year % 100 - y));
                topText.Items.Add(string.Format("{0}A_", DateTime.Now.Year % 100 - y));
            }
            string q = string.Empty;
            int ct = DateTime.Now.Month;
            if (1 <= ct && ct <= 3) { q = "A"; }
            if (4 <= ct && ct <= 6) { q = "B"; }
            if (7 <= ct && ct <= 9) { q = "C"; }
            if (10 <= ct && ct <= 12) { q = "D"; }
            topText.Text = string.Format("{0}{1}_", DateTime.Now.Year%100, q);
        }

        private void フォルダ作成CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm dlg = new CreateForm(path.Text);
            dlg.ShowDialog();
        }

        private void run_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = resultView.RowCount-1; 0 <= i; i--)
            {
                if ((bool)resultView.Rows[i].Cells[0].Value)
                {
                    File.Move(resultView.Rows[i].Cells[3].Value.ToString(), resultView.Rows[i].Cells[4].Value.ToString());
                    resultView.Rows.RemoveAt(i);
                    cnt++;
                }
            }
            resultView.AlternatingRowsDefaultCellStyle.BackColor = Color.PowderBlue;
            MessageBox.Show(string.Format("{0}件のファイルを移動しました。", cnt));
        }

        private void movefile(bool flg)
        {
            resultView.Rows.Clear();
            int cnt=0;

            string[] files = Directory.GetFiles(path.Text);
            string[] dirs = Directory.GetDirectories(path.Text, string.Format("{0}*", topText.Text));

            foreach (string fn in files)
            {
                if (Path.GetFileName(fn).Length < TOPLENGTH) { continue; }
                int cs = (int)compSize.Value;
                if (Path.GetFileName(fn).Length < TOPLENGTH + cs)
                {
                    cs = Path.GetFileName(fn).Length - TOPLENGTH;
                }

                string filenm = Path.GetFileName(fn).Substring(TOPLENGTH, (int)compSize.Value);

                foreach (string dn in dirs)
                {
                    string dirnm = Path.GetFileName(dn);
                    dirnm = dirnm.Substring(4, cs);

                    if (filenm.Equals(dirnm))
                    {
                        resultView.Rows.Add(true, Path.GetFileName(dn), Path.GetFileName(fn).Substring(TOPLENGTH)
                            , fn, string.Format("{0}\\{1}", dn, Path.GetFileName(fn)));
                        if (flg)
                        {
                            File.Move(fn, string.Format("{0}\\{1}", dn, Path.GetFileName(fn)));
                            cnt++;
                        }
                    }
                }
            }

            resultView.AlternatingRowsDefaultCellStyle.BackColor = Color.PowderBlue;

            if (flg)
            {
                MessageBox.Show(string.Format("{0}件のファイルを移動しました。", cnt));
            }
        }

        private void testbtn_Click(object sender, EventArgs e)
        {
            this.movefile(false);
        }
    }
}