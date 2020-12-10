using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg139
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (Control obj in Controls)
            {
                if (obj is Button)            //Buttonと等しい場合
                {
                    obj.Text = "Clicked!";      //プロパティの値を変更
                }
            }
        }
    }
}
