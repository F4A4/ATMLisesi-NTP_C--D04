using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "string")
            {
                textBox1.Text = "Elliiki";
            }
            else if (listBox1.Text == "int")
            {
                int i = 52;
                textBox1.Text = i.ToString();
            }
            else if (listBox1.Text == "char")
            {
                char i = '@';
                textBox1.Text = i.ToString();
            }
            else if (listBox1.Text == "double")
            {
                double i = 0.20;
                textBox1.Text = i.ToString();
            }
            else if (listBox1.Text == "float")
            {
                float i = 0.23F;
                textBox1.Text = i.ToString();
            }
            else if (listBox1.Text == "boolean")
            {
                bool i = true;
                textBox1.Text = i.ToString();
            }
            else if (listBox1.Text == "decimal")
            {
                decimal i = 12121212M;
                textBox1.Text = i.ToString();
            }
            else if (listBox1.Text == "long")
            {
                long i = 30L;
                textBox1.Text = i.ToString();
            }

        //    switch (listBox1.Text)
        //    {
        //        case "string":
        //            {
        //                StringYaz();
        //                break;
        //            }
        //        case "int":
        //            {
        //                IntYaz();
        //                break;
        //            }
        //        case "char":
        //            {
        //                CharYaz();
        //                break;
        //            }
        //        case "double":
        //            {
        //                DoubleYaz();
        //                break;
        //            }
        //        default:
        //            break;
        //    }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void StringYaz()
        //{
        //    textBox1.Text = "Elliiki";
        //}
        //private void IntYaz()
        //{
        //    textBox1.Text = "52";
        //}
        //private void CharYaz()
        //{
        //    char i = '@';
        //    textBox1.Text = i.ToString();
        //}
        //private void DoubleYaz()
        //{
        //    textBox1.Text = "5,2";
        //}
    }
}

