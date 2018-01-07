using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_UlewiczNienajadloRekawek
{
    class UNRCzasy
    {
        int UNRrozmiar;
        double UNRczaspomiar;
        double UNRczasobliczony;

        public UNRCzasy() { 
        
        }

        public int UNRUstawRozmiar(int UNRrozmiartablicy) {

            return this.UNRrozmiar = UNRrozmiartablicy; 

        }

        public double UNRUstawCzasPomiaru(double UNRCzasPomiar) {

            return this.UNRczaspomiar = UNRCzasPomiar;
        
        }

        public double UNRUstawCzasObliczony(double UNRCzasPomiar)
        {
            return this.UNRczasobliczony = UNRCzasPomiar;
        
        }

        public int UNRGetRozmiar()
        {

            return this.UNRrozmiar;

        }

        public double UNRGetCzasPomiaru()
        {

            return this.UNRczaspomiar;

        }

        public double UNRGetCzasObliczony()
        {
            return this.UNRczasobliczony;

        }
    }
}
