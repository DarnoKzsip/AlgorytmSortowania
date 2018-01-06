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
        long UNRczaspomiar;
        int UNRczasobliczony;

        public UNRCzasy() { 
        
        }

        public int UNRUstawRozmiar(int UNRrozmiartablicy) {

            return this.UNRrozmiar = UNRrozmiartablicy; 

        }

        public long UNRUstawCzasPomiaru(long UNRCzasPomiar) {

            return this.UNRczaspomiar = UNRCzasPomiar;
        
        }

        void UNRUstawCzasObliczony() { 
        //TODO Dopisać obliczanie czasu
        
        }
    }
}
