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
            string[] names = { "�r��", "����", "��", "���J", "���" };
            int index = comboBox1.SelectedIndex;
            if (index == -1)  //�I������Ă��Ȃ��Ƃ�
            {
                label1.Text = "�N���X��I�����Ă��������B";
                return;
            }
            label1.Text = comboBox1.SelectedItem
                + $" �S�C�F{names[index]} �搶";
        }
    }
}
