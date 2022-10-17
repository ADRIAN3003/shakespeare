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

        private int ev;

        public int Ev
        {
            get { return ev; }
            private set { ev = value; }
        }

        private bool komedia;

        public bool Komedia
        {
            get { return komedia; }
            private set { komedia = value; }
        }

        public Shakespeare(string magyarCim, string angolCim, int ev, bool komedia)
        {
            MagyarCim = magyarCim;
            AngolCim = angolCim;
            Ev = ev;
            Komedia = komedia;
        }
    }
}
