using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shakespeare
{
    class Shakespeare
    {
        private string magyarCim;

        public string MagyarCim
        {
            get { return magyarCim; }
            private set { magyarCim = value; }
        }

        private string angolCim;

        public string AngolCim
        {
            get { return angolCim; }
            private set { angolCim = value; }
        }

        private int befejezes;

        public int Befejezes
        {
            get { return befejezes; }
            private set { befejezes = value; }
        }

        private bool komedia;

        public bool Komedia
        {
            get { return komedia; }
            private set { komedia = value; }
        }

        public Shakespeare(string magyarCim, string angolCim, int befejezes, bool komedia)
        {
            MagyarCim = magyarCim;
            AngolCim = angolCim;
            Befejezes = befejezes;
            Komedia = komedia;
        }
    }
}
