using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace error321
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
            try
            {
                sample(text);
            }
            catch ( FormatException ex )
            {
                MessageBox.Show(ex.Message, "エラー発生");
            }
        }

        int sample( string text )
        {
            int a = int.Parse(text);
            return a;
        }
    }
}
