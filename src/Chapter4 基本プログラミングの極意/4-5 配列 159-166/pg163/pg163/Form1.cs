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
            var student = new int[3][];     //ジャグ配列の宣言

            //0～2までの各要素を、それぞれ要素数と初期値を指定する
            student[0] = new int[3] { 37, 35, 34 };      //1年を3クラス分
            student[1] = new int[2] { 41, 43 };          //2年を2クラス分
            student[2] = new int[4] { 33, 34, 33, 35 };  //3年を4クラス分

            listBox1.Items.Clear();
            for (int i = 0; i < student.Length; i++)
            {
                listBox1.Items.Add($"{i + 1} 年");
                for (int j = 0; j < student[i].Length; j++)
                {
                    listBox1.Items.Add($"\t {j + 1}組 {student[i][j]}");
                }
            }
        }
    }
}
