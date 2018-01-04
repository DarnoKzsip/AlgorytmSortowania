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
        int UNRczaspomiar;
        int UNRczasobliczony;

        public UNRCzasy() { 
        
        }

        void UNRUstawRozmiar(int UNRrozmiartablicy) {

            this.UNRrozmiar = UNRrozmiartablicy; 

        }

        void UNRUstawCzasPomiaru(int UNRCzasPomiar) {

            this.UNRczaspomiar = UNRCzasPomiar;
        
        }

        void UNRUstawCzasObliczony() { 
        //TODO Dopisać obliczanie czasu
        
        }
    }
}
