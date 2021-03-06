using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file264
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
            if ( path == string.Empty )
            {
                return;
            }
            if ( System.IO.File.Exists( path ) == false )
            {
                MessageBox.Show("ファイルが見つかりませんでした");
                return;
            }
            listBox1.Items.Clear();
            var sr = new System.IO.StreamReader(path);
            string line = null;
            while ( (line = sr.ReadLine()) != null )
            {
                listBox1.Items.Add(line);
            }
            sr.Close();
        }
    }
}
