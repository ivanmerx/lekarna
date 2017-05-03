using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekarna
{
    class Zakaznik_Alergeny
    {
        private int zakaznik_id;
        private string alergen;
        public int Zakaznik_ID
        {
            get
            {
                return zakaznik_id;
            }
            set
            {
                zakaznik_id = value;
            }
        }

        public string Alergen
        {
            get
            {
                return alergen;
            }
            set
            {
                alergen = value;
            }
        }
    }
}
