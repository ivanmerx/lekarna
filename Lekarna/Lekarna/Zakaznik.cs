using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lekarna
{
    public class Zakaznik : IOsoba_Info
    {
        public string Jmeno { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Prijmeni { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int ID
        {
            get => default(int);
            set
            {
            }
        }

        public bool Clen
        {
            get => default(int);
            set
            {
            }
        }
    }
}