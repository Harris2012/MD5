using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MD5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SourceFileBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] DT = e.Data.GetData(DataFormats.FileDrop) as string[];
                if (DT == null || DT.Length != 1)
                    return;
                FileInfo info = new FileInfo(DT[0]);
                if (!info.Exists)
                    return;
                e.Effect = DragDropEffects.Move;
            }
        }

        private void SourceFileBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] DT = e.Data.GetData(DataFormats.FileDrop) as string[];
                if (DT == null || DT.Length != 1)
                    return;
                FileInfo info = new FileInfo(DT[0]);
                if (!info.Exists)
                    return;
                btCopy.Enabled = false;
                labelMD5.Text = Functions.MDFile(info.FullName);
                btCopy.Enabled = true;
            }            
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            if (labelMD5.Text.Equals(""))
                MessageBox.Show("当前没有可以复制的MD5数值", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
            {
                Clipboard.SetText("MD5:" + labelMD5.Text);
                MessageBox.Show("MD5数值已成功复制到剪切板", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
