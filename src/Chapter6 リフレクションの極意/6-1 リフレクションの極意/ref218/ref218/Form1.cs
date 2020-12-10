using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ref218
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var obj = new SampleClass()
            {
                ID = 100,
                Name = "マスダトモアキ",
                Address = "板橋区"
            };
            textBox1.Text = obj.Name;

            // プロパティ情報を取得する
            var pi = typeof(SampleClass).GetProperty("Name");
            pi.SetValue(obj, "増田智明");
            // プロパティを表示
            textBox2.Text = obj.Name;
        }
    }
    public class SampleClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string ShowData()
        {
            return $"{ID} : {Name} in {Address}";
        }
        public void ChangeName( string name )
        {
            this.Name = name;
        }
    }
}
