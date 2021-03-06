using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file272
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            if (path == string.Empty)
            {
                return;
            }
            byte[] data = new byte[1024];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = 0xFF;
            }
            var fs = System.IO.File.Create(path);
            for (int i = 0; i < 1024 * 100; i++)
            {
                fs.Write(data, 0, data.Length);
            }
            fs.Close();
            MessageBox.Show("100MBのファイルを作成しました");
        }
    }
}
