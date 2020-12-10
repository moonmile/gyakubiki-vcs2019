﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui120
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 新規ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myFm = new Form();  //子フォームの作成

            //リッチテキストボックスの作成と設定
            RichTextBox myRT = new RichTextBox();
            myRT.Dock = DockStyle.Fill;

            //子フォームの設定
            myFm.MdiParent = this;  //親フォームを設定
            myFm.Text = "文書" + MdiChildren.Length; //タイトルバーの設定
            myFm.Size = new Size(200, 200); //フォームのサイズを設定
            myFm.Controls.Add(myRT); //リッチテキストボックスの追加
            myFm.Show(); //フォームを開く

        }

        private void 左右に整列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical); //左右に並べて表示
        }

        private void 上下に整列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal); //上下に並べて表示

        }

        private void 重ねて整列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade); //重ねて表示

        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 閉じるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myFm = this.ActiveMdiChild; //子フォームを変数myFmに代入
            if (myFm==null)
            {
                return;
            }
            else
            {
                myFm.Close(); //子フォームを閉じる
            }
        }
    }
}
