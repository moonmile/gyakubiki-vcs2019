using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace async212
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Threading.ManualResetEvent mre;

        private async void Button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                mre = new System.Threading.ManualResetEvent(false);
                for ( int i=0; i<20; i++ )
                {
                    if ( i == 10 )
                    {
                        // 10秒後にイベント待ちになる
                        this.Invoke(new Action(() => {
                            label1.Text = "解除イベント待ち";
                        }));
                        mre.Reset();
                        mre.WaitOne();
                    }
                    this.Invoke(new Action(() =>
                    {
                        label1.Text = $"{i} 秒経過";
                    }));
                    System.Threading.Thread.Sleep(1000);
                }
            });
            label1.Text = "タスク終了";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // イベント待ちを解除
            mre.Set();
        }
    }
}
