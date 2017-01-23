using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Rengas
    {
        public string Valmistaja { get; set; }
        public string Malli { get; set; }
        public int Rengaskoko { get; set; }

        public override string ToString()
        {

            return string.Format("Valmistaja: {0}  Malli: {1} Rengaskoko : {2}", Valmistaja, Malli, Rengaskoko);
            
        }
    }
    class Auto
    {
        public string Merkki { get; set; }
        public string Malli { get; set; }
        private int maxRenkaidenLkm = 4;
        private int renkaidenLkm;
        public int RenkaidenLkm { get { return renkaidenLkm; } }

        private bool onkoMaxRengas = false;
        public bool OnkoMaxRengas { get { return onkoMaxRengas; } }
        public List<Rengas> Renkaat; 
        
        public void LisaaRengas(Rengas rengas)
        {
            if (renkaidenLkm < maxRenkaidenLkm)
            {
                Renkaat.Add(rengas);
                renkaidenLkm++;
                onkoMaxRengas = false;
            }
            else
                onkoMaxRengas = true;
  
        }
        public override string ToString()
        {
            string s;
            s = "Ajoneuvon Merkki: " + Merkki + "   Malli: " + Malli;
            s += "\nRenkaat: ";
            foreach (Rengas rengas in Renkaat)
            {

                s += "\n" + rengas.ToString();
            }
            return s;
        }
        public Auto()
        {
            Renkaat = new List<Rengas>();
        }


    }
   
        


    

}
