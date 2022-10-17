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

            MessageBox.Show("Nem komédiák kiírva fájlba!");
        }
    }
}
