using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg197
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 読み取り専用クラス
        public class ReadOnly<T>
        {
            private T _value;
            public ReadOnly( T value ) { _value = value; }
            public T Value => _value;
        }

        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var name = new ReadOnly<string>("masuda");
            var age = new ReadOnly<int>(51);

            label1.Text = name.Value;
            label2.Text = age.Value.ToString();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            string a = "マスダ";
            string b = "智明";

            Swap(ref a, ref b);

            label1.Text = a;
            label2.Text = b;
        }
    }

}
