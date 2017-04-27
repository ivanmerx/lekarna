using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lekarna
{
    public class Pracovnik : IOsoba_Info
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

        public string Heslo
        {
            get => default(int);
            set
            {
            }
        }

        public string Prihlasovaci_Jmeno
        {
            get => default(int);
            set
            {
            }
        }
    }
}