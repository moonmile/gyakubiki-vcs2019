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
namespace debug349
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("�C���f���g�O");
            Debug.Indent();
            Debug.WriteLine("�C���f���g1���");
            Debug.Indent();
            Debug.WriteLine("�C���f���g2���");
            Debug.Unindent();
            Debug.WriteLine("�C���f���g��߂�");
            Debug.Unindent();
            Debug.WriteLine("�C���f���g��߂�");
        }
    }
}
