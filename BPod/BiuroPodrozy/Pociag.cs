using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozy
{
    class Pociag: SrodekLokomocji
    {
        private int dlugoscTrasy;

        public override void ObliczCene()
        {
            if (dlugoscTrasy > 100) cenaBiletu = dlugoscTrasy * 1.43;
            else cenaBiletu = 62; 
        }

        public Pociag(int iloscMiejsc, int dlugoscTrasy)
        {
            this.iloscMiejsc = iloscMiejsc;
            this.dlugoscTrasy = dlugoscTrasy;
            ObliczCene();
        }

        public override string ToString()
        {
            return "Pociag: ilosc miejsc: " + iloscMiejsc + "Dlugosc trasy: " + dlugoscTrasy + "cena biletu: " + cenaBiletu + ".";
        }
    }
}
