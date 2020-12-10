using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg160
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] names = { "荒俣", "夢野", "沼", "柄谷", "上野" };
            int index = comboBox1.SelectedIndex;
            if (index == -1)  //選択されていないとき
            {
                label1.Text = "クラスを選択してください。";
                return;
            }
            label1.Text = comboBox1.SelectedItem
                + $" 担任：{names[index]} 先生";
        }
    }
}
