using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lekarna
{
    public class Objednavka
    {
        public int ID
        {
            get;
            set;
        }

        public int ID_Zakaznika
        {
            get;
            set;
        }

        public int Cena
        {
            get;
            set;
        }

        public string Produkty
        {
            get;
            set;
        }
    }
}