using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg167
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> lst = new List<string>(); //List<T>のインスタンス作成

        private void Button1_Click(object sender, EventArgs e)
        {
            // 項目をひとつ追加
            lst.Add(DateTime.Now.ToString());
            // 結果をリストボックスに表示
            listBox1.Items.Clear();
            listBox1.Items.AddRange(lst.ToArray());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // 項目をすべて削除
            lst.Clear();
            // 結果をリストボックスに削除
            listBox1.Items.Clear();
            listBox1.Items.AddRange(lst.ToArray());
        }
    }
}
