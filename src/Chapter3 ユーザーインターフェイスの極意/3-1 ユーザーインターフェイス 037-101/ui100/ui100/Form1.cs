﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui100
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (TextBox myTB in panel1.Controls)
            {
                myTB.Text = myTB.Name;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            foreach (TextBox myTB in panel1.Controls)
            {
                myTB.Clear();
            }

        }
    }
}
