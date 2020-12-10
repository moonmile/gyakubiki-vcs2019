using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace async211
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                for ( int i=0; i<10; i++ )
                {
                    this.Invoke(new Action(() =>
                    {
                        label1.Text = $"{i} 秒経過";
                    }));
                    System.Threading.Thread.Sleep(1000);
                }
            });
            label1.Text = "完了";
        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            await Task.Run( async () =>
            {
                for (int i = 0; i < 10; i++)
                {
                    this.Invoke(new Action(() =>
                    {
                        label1.Text = $"{i} 秒経過";
                    }));
                    await Task.Delay(1000);
                }
            });
            label1.Text = "完了";
        }
    }
}
