using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg140
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int? x;

            if ( textBox1.Text == "" )
            {
                x = null;
            }
            else
            {
                x = int.Parse(textBox1.Text);
            }

            label2.Text = "変数 x = " + (x ?? 0).ToString();
        }
    }
}
