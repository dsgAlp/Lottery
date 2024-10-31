using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd;
        int[] sansliSayilar;
        Label[] labels;

        int sira = 0, sayac = 1, frekans = 10;
        private void Form1_Load(object sender, EventArgs e)
        {
            sansliSayilar = new int[6];
            labels = new Label[] { lbl1, lbl2, lbl3, lbl4, lbl5, lbl6 };
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            Sifirla();
            SayiUret();
            timer1.Start();
        }

        private void Sifirla()
        {
            lbxSansliSayilar.Items.Clear();
            sira = 0;
        }

        private void SayiUret()
        {
            rnd = new Random();
            int sayi;

            for (int i = 0; i < sansliSayilar.Length; i++)
            {
                do
                {
                    sayi = rnd.Next(1, 50);
                } while (sansliSayilar.Contains(sayi));          //26-35-49-11-45-23  i=5

                //if (sansliSayilar.Contains(sayi))
                //{
                //    i--;//i=2
                //    continue;
                //}
                sansliSayilar[i] = sayi;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //animasyon...
            for (int i = sira; i < labels.Length; i++)
            {
                labels[i].Text = rnd.Next(1, 50).ToString().PadLeft(2, '0');
            }

            if (sayac++ % frekans == 0)
            {
                if (sira < labels.Length)
                {
                    labels[sira].Text = sansliSayilar[sira].ToString().PadLeft(2, '0');
                    lbxSansliSayilar.Items.Add(sansliSayilar[sira].ToString().PadLeft(2, '0'));
                }
                sira++;
            }

            if (sira > labels.Length)
            {
                foreach (Label item in labels)
                {
                    item.Visible = !item.Visible;
                }
            }

            if (sira == labels.Length + 3)
            {
                timer1.Stop();
                Array.Sort(sansliSayilar);
                for (int i = 0; i < labels.Length; i++)
                {
                    labels[i].Visible = true;
                    labels[i].Text = sansliSayilar[i].ToString().PadLeft(2, '0');
                }
            }

        }
    }
}
