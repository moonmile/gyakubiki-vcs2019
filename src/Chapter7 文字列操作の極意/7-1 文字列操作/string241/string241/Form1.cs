using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string241
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            // 文字を指定して分割
            var ary = text.Split('/');
            listBox1.Items.Clear();
            foreach ( var t in ary )
            {
                listBox1.Items.Add(t);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            // 文字列を指定して分割
            var ary = text.Split(new string[] { "/" },
                StringSplitOptions.None );
            listBox1.Items.Clear();
            foreach (var t in ary)
            {
                listBox1.Items.Add(t);
            }
        }
    }
}
