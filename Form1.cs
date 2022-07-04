using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxtakiVeriyiMaskeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool show = false;
        string Mask(string textvalue, bool check)
        {
            if (check)
            {
                var first = textvalue.Substring(0, 2);
                var last = textvalue.Substring(textvalue.Length - 2, 2);
                var mask = new string('*', textvalue.Length - first.Length - last.Length);
                var masked = string.Concat(first, mask, last);
                return masked.ToString();
            }
            else
            {
                return textvalue;
            }

        }

        void Print()
        {
            txtVeri.Text = Mask("12345678930", show);
        }

        private void btnMaskele_Click(object sender, EventArgs e)
        {
            show = true;
            Print();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Print();
        }

        private void btnMaskeAc_Click(object sender, EventArgs e)
        {
            show = false;
            Print();
        }
    }
}
