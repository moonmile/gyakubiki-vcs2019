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

namespace debug355
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var eLog = new EventLogTraceListener("Debug355");
            Debug.Listeners.Add(eLog); // 出力先を追加する
            Debug.WriteLine("button1がクリックされました。");
            Debug.Flush();
            MessageBox.Show("イベントログに出力しました。", "通知");
        }
    }
}
