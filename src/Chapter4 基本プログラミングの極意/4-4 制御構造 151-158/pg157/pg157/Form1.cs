using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg157
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string s = "";
            /// チェック済みを調べる
            foreach( CheckBox chk in groupBox1.Controls )
            {
                if ( chk.Checked )
                {
                    s += chk.Text + "、";
                }
            }
            label1.Text = $"{s} を選択しました";
        }
    }
}
