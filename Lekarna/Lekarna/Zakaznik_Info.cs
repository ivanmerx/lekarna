using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lekarna
{
    public class Zakaznik_Info : IOsoba_Detail_Info
    {
        public int ID_Zakaznika
        {
            get;
            set;
        }

        public string Bydliste { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Dat_Nar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}