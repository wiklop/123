using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozy
{
    class Podroz: IZarzadzaj, IData
    {
        private DateTime dataPodrozy;
        private List<SrodekLokomocji> planPodrozy;
        private double koszt = 0;

        public Podroz()
        {
            planPodrozy = new List<SrodekLokomocji>();
        }

        public void DodajAutobus(int iloscMiejsc)
        {
            planPodrozy.Add(new Autobus(iloscMiejsc));
            int pomoc = planPodrozy.Count;
            koszt += planPodrozy[pomoc-1].ZwrocCene();
        }

        public void DodajPociag(int iloscMiejsc, int dlugoscTrasy)
        {
            planPodrozy.Add(new Pociag(iloscMiejsc, dlugoscTrasy));
            int pomoc = planPodrozy.Count;
            koszt += planPodrozy[pomoc-1].ZwrocCene();
        }

      

      

        public void UsunOstatni()
        {
            if (planPodrozy.Count > 0) planPodrozy.Remove(planPodrozy.Last());

        }

        public void Wyczysc()
        {
            planPodrozy.Clear();
        }

        public void UstawDate(DateTime data)
        {
            dataPodrozy = data;
        }

        public bool SprawdzDate()
        {
            if (dataPodrozy > DateTime.Now) return true;
            else return false;
        }

        public override string ToString()
        {
            string info = "Plan podrozy: ";

            foreach (var element in planPodrozy)
            {
                info += Environment.NewLine + element.ToString();
            }
            info += Environment.NewLine + "Koszt: " + koszt;

            return info;
        }
    }
}
