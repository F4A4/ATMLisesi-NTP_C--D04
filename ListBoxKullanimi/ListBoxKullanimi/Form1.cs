using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBoxKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("konya");
            listBox1.Items.Add("ankara");
            listBox1.Items.Add("manisa");
        }

        //Listbox lara ve benzeri nesnelere eleman eklemek için
        //bu ve buna benzer kodlar kullanılır.

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                MessageBox.Show(listBox1.Items[i].ToString());
            }

            MessageBox.Show(String.Format("Listbox ımızın {0} tane elemanı vardır.", listBox1.Items.Count));
        }

        //Listbox ların ve benzeri nesnelerin eleman sayımarını öğrenebilmek için
        //listBox1.Items.Count benzeri kodlar kullanılır.

        //kaç elemanlı olduğunu öğrendikten sonra for ile tüm elemanlar
        //arasında döngü kurulabilir.

        //Console.WriteLine() içinde kullanabildiğimiz string format komutunun
        //aslı yukarıdaki gibidir. Başına String.Format yazmak
        //en doğrusu olur. Aksi taktirde mbox hata verir.

        //ÖDEV : 10 elemanlı bir string array (dizi) oluşturun ve elemanlarını elinizle yazın
        //butona basıldığında dizinin tüm elemanlarını listbox a doldursun.
    }
}
