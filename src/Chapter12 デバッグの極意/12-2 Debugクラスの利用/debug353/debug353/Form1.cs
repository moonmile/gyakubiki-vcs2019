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
using System.Diagnostics;
namespace debug353
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 30; i++)
            {
                if (i > 25)
                {
                    // �x�����b�Z�[�W�Əڍ׃��b�Z�[�W��\������
                    Debug.Fail("����I�[�o�[�ł��B",
                        "�u�ȒP�N�b�L���O�R�[�X�v�̒����25���ł��B");
                }
            }
        }
    }
}
