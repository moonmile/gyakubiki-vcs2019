using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace pg133
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string json = @"{ name: ""masuda"", age: 51 }";
            // dynamic 型に変換してプロパティを使う
            var o = (dynamic)JsonConvert.DeserializeObject(json);
            label3.Text = o.name;
            label4.Text = o.age.ToString();
        }
    }
}
