using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg163
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var student = new int[3][];     //�W���O�z��̐錾

            //0�`2�܂ł̊e�v�f���A���ꂼ��v�f���Ə����l���w�肷��
            student[0] = new int[3] { 37, 35, 34 };      //1�N��3�N���X��
            student[1] = new int[2] { 41, 43 };          //2�N��2�N���X��
            student[2] = new int[4] { 33, 34, 33, 35 };  //3�N��4�N���X��

            listBox1.Items.Clear();
            for (int i = 0; i < student.Length; i++)
            {
                listBox1.Items.Add($"{i + 1} �N");
                for (int j = 0; j < student[i].Length; j++)
                {
                    listBox1.Items.Add($"\t {j + 1}�g {student[i][j]}");
                }
            }
        }
    }
}
