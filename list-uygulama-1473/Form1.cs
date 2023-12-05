using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_uygulama_1473
{
    public partial class Form1 : Form
    {
      List<string> kişiler = new List<string>();
        int indexsira = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kişiler.Add("sema");
            kişiler.Add("melisa");
            kişiler.Add("sukeyna");
            kişiler.Add("ilayda");
            kişiler.Add("hayrunisa");
            kişiler.Add("kübra");

            listBox1.DataSource = kişiler.ToList();

        }

        private void btnKişiEkle_Click(object sender, EventArgs e)
        {
            kişiler.Add(txtAd.Text);
            listBox1.DataSource = kişiler.ToList();
          
        }

        private void btn_Click(object sender, EventArgs e)
        {
            bool durum = kişiler.Contains(txtAd.Text);
            if(durum)
            {
                MessageBox.Show("aradığınız kişi mevcut");
            }
            else
            {
                MessageBox.Show("aradığınız kişi mevcut deyil ");
            }
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            int sira= kişiler.IndexOf(txtAd.Text);
            if (sira > -1)
            {
                MessageBox.Show(txtAd.Text+" "+sira +"sıralamasıdır");
            }
            else
            {
                MessageBox.Show(txtAd.Text + "sıralamada yok.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sira =kişiler .IndexOf(txtAd.Text);
            if ( sira > -1)
            {
                kişiler.RemoveAt(sira);//REOMV-> BELİRTİLEN İNDEX SIRASINDAKİ SEYERİ SİLER
            }

            listBox1.DataSource = kişiler.ToList();//listbox günçele
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool durumm = kişiler .Contains (txtAd.Text);
            if (durumm)
            {
                kişiler.Remove (txtAd.Text);//kişi adı ile silme
            }

            listBox1.DataSource = kişiler.ToList();// listbox güncelle
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAd.Text = listBox1.SelectedValue.ToString();
            indexsira = listBox1.SelectedIndex;
            // lisbox içindeki sırayı verir
            //aynı sıralamaa list (kişiler4)  içinde geçerli
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(indexsira.ToString());
            kişiler[indexsira] = txtAd.Text;
            
            listBox1.DataSource =kişiler .ToList();// list güncele 
        }

        private void btnAlfabetik_Click(object sender, EventArgs e)
        {
            kişiler.Sort();

            listBox1.DataSource = kişiler.ToList();// listbox güncele

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            kişiler.Sort();
            

            listBox1.DataSource = kişiler.ToList();// listbox güncele
        }

      

        private void button1_Click_2(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < kişiler.Count; i++)
            {
                if (kişiler[i].Length == 5)
                {
                    sayac++;
                }
            }
            MessageBox.Show("5 karakterli:" + sayac + "tam öğrençi mevcut");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < kişiler.Count; i++)
            {
                if (kişiler[i][0]=='M')
                {
                    sayac++;
                }
            }
            MessageBox.Show("M karakterli:" + sayac + "tame öğrençi mevcut");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kişiler.Clear();
            listBox1.DataSource = kişiler.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < kişiler.Count; i++)
            {
                string kisi = kişiler[i];
                if (kisi [kisi .Length-1] == 'a')
                {
                    sayac++;
                }
            }
            MessageBox.Show("son harfi a karakteridir:" + sayac + "tam öğrençi mevcut");

        }
    }
}
