using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace shakespeare
{
    public partial class Form1 : Form
    {
        static List<Shakespeare> shakespeares = new List<Shakespeare>();

        public Form1()
        {
            InitializeComponent();
            lblTalalat.Text = "";
            lblUtolsoMuve.Text = "";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("shakespeare.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] adat = sr.ReadLine().Split(';');
                    string magyarCim = adat[0];
                    string angolCim = adat[1];
                    int ev = Convert.ToInt32(adat[2]);
                    bool komedia = adat[3] == "igen";
                    shakespeares.Add(new Shakespeare(magyarCim, angolCim, ev, komedia));
                }
            }

            lblDarab.Text = shakespeares.Count + " Shakespeare dráma adatait eltároltuk";
        }

        private void btnNemKomediak_Click(object sender, EventArgs e)
        {
            if (vanTragediaEsKiralyDrama())
            {
                using (StreamWriter sw = new StreamWriter("dramak.txt"))
                {
                    foreach (var shakespeare in shakespeares)
                    {
                        if (!shakespeare.Komedia)
                        {
                            sw.WriteLine(shakespeare.AngolCim);
                        }
                    }
                }
                MessageBox.Show("tragédiák és királydrámák angol címét kiírtam a dramak.txt-be");
            } 
            else
            {
                MessageBox.Show("Nincsenek tragédiák és királydrámák ezért nem  írtam ki a dramak.txt-be");
            }

        }

        private bool vanTragediaEsKiralyDrama()
        {
            //bool van = false;
            //foreach (var shakespeare in shakespeares)
            //{
            //    if (!shakespeare.Komedia)
            //    {
            //        van = true;
            //    }
            //}
            //return van;

            //bool nincs = true;
            //int i = 0;
            //while (i < shakespeares.Count && nincs)
            //{
            //    nincs = shakespeares[i].Komedia;
            //    i++;
            //}
            //return !nincs;

            return shakespeares.Count(x => !x.Komedia) != 0;
        }

        private void btnKereses_Click(object sender, EventArgs e)
        {
            bool van = false;
            foreach (var shakespeare in shakespeares)
            {
                if (!van && shakespeare.Ev == Convert.ToInt32(tbEvSzam.Text))
                {
                    van = true;
                    lblTalalat.Text = shakespeare.MagyarCim + "\n" + shakespeare.AngolCim + "\n" + (shakespeare.Komedia ? "Komédia" : "Dráma");
                }
            }

            if (!van)
            {
                lblTalalat.Text = "Nem találtam megfelelő drámát";
                MessageBox.Show("Nem találtam megfelelő drámát");
            }
        }

        private void btnUtolsoMuve_Click(object sender, EventArgs e)
        {
            lblUtolsoMuve.Text = shakespeares.OrderBy(x => x.Ev).Last().AngolCim;
        }
    }
}
