using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg156
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i = 100; // �����l��100�ɂ���
            do
            {
                listBox1.Items.Add($"No. {i}");
                i++;
            } while (i < 10);
        }
    }
}
