using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DegışgenTurlerı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("ankara");
            listBox1.Items.Add("bursa");
            listBox1.Items.Add("konya");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                MessageBox.Show(listBox1.Items[i].ToString());
                
            }
            MessageBox.Show(String.Format("ListBox'ın içinde {0} tane eleman bulunmaktadır.",listBox1.Items.Count));
        }

        
        

        


        
       

       

       
    }
}
