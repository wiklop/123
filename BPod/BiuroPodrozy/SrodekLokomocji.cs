using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozy
{
    abstract class SrodekLokomocji
    {
        protected int iloscMiejsc;
        protected double cenaBiletu;

        public SrodekLokomocji() { }

        public virtual void ObliczCene()
        {
            DateTime teraz = DateTime.Now;

            cenaBiletu = Convert.ToInt32(teraz.Day);
        }

        public double ZwrocCene() 
        {
            return this.cenaBiletu;
        }
    }
}
