using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_UlewiczNienajadloRekawek
{
    class UNRRandomArray
    {
        int UNRDolnaWartosc;
        int UNRGornaWartosc;
        int UNRRozmairAktualny;
        List<Int32> UNRTablicaSortowania = new List<Int32>();
        int UNRSeed = 0; // inicjator wartości Random(bez wstawiania tych samych wartości ze względu na Timestamp)

        public UNRRandomArray(int UNRDolnaWartosc, int UNRGornaWartosc, int UNRRozmairAktualny ) {

            this.UNRDolnaWartosc = UNRDolnaWartosc;
            this.UNRGornaWartosc = UNRGornaWartosc;
            this.UNRRozmairAktualny = UNRRozmairAktualny;
        
        }


        List<Int32> UNRGenerujTablice (){
        for (int i = 1; i < UNRRozmairAktualny; i++)
            {

                Random UNRRandom = new Random(UNRSeed);
                UNRTablicaSortowania.Add(UNRRandom.Next(UNRDolnaWartosc, UNRGornaWartosc));
                UNRSeed++;


            }

        return UNRTablicaSortowania;
        }
    }
}
