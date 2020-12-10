using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg181
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public string[] changeArray(string[] ary)
        {
            var result = new string[ary.Length];
            for (int i = 0; i < ary.Length; i++)
            {
                result[i] = ary[i].ToUpper();
            }
            return result;
        }

        public List<string> changeList(List<string> lst)
        {
            var result = new List<string>();
            foreach (var it in lst)
            {
                result.Add(it.ToUpper());
            }
            return result;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] ary =
            {
                "microsoft",
                "apple",
                "ibm",
                "oracle",
                "shuwasystem"
            };
            // 表示する
            listBox1.Items.Clear();
            foreach (var it in ary)
            {
                listBox1.Items.Add(it);
            }
            // 変換する（配列を引数にしてchangeArrayメソッドを呼び出し、
            // 結果を変数ary2に返す)
            string[] ary2 = changeArray(ary);
            // 表示する
            listBox2.Items.Clear();
            foreach (var it in ary2)
            {
                listBox2.Items.Add(it);
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            //リストlstのインスタンス生成と初期化
            List<string> lst = new List<string> 
            {
                "microsoft",
                "apple",
                "ibm",
                "oracle",
                "shuwasystem"
            };
            // 表示する
            listBox1.Items.Clear();
            lst.ForEach(it => listBox1.Items.Add(it));　//ForEachメソッドの使用
            // 変換する
            var lst2 = changeList(lst);　//リストを引数にメソッドを呼び出す
            // 表示する
            listBox2.Items.Clear();
            lst2.ForEach(it => listBox2.Items.Add(it));
        }
    }
}
