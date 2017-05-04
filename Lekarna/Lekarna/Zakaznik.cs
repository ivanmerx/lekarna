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
            get;
            set;
        }

        public bool Clen
        {
            get;
            set;
        }

        public int Rodne_Cislo
        {
            get => default(int);
            set
            {
            }
        }
    }
}