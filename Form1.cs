using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  


        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string [] aylar = new string [11] {"Ocak","Şubat",
                              "Mart","Nisan",
                              "Mayıs","Haziran",
                              "Temmuz","Ağustos",
                              "Eylül","Ekim", "Kasım","Aralık"};
             for (int i = 0; i <=11; i++)
            {
                listBox1.Items.Add(aylar[i].ToString());
                
            }                
            //listBox1.Items.Add(aylar[0]);
            //listBox1.Items.Add(aylar[1]);
            //listBox1.Items.Add(aylar[2]);
            //listBox1.Items.Add(aylar[3]);
            //listBox1.Items.Add(aylar[4]);
            //listBox1.Items.Add(aylar[5]);
            //listBox1.Items.Add(aylar[6]);
            //listBox1.Items.Add(aylar[7]);
            //listBox1.Items.Add(aylar[8]);
            //listBox1.Items.Add(aylar[9]); 
            //listBox1.Items.Add(aylar[10]);
            //listBox1.Items.Add(aylar[11]);
            
            MessageBox.Show(String.Format("listbox içinde {0} bulunmaktadır "+ listBox.Items.Add(aylar[i] ));
          
            

         
        


        }
    }
}
