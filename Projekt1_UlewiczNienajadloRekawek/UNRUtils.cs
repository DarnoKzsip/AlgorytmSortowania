using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_UlewiczNienajadloRekawek
{
    abstract class UNRUtils
    {

        //Funkcja losująca

        public static List<Int32> UNRLosowanie(int UNRDolnaGranica, int UNRGornaGranica, int UNRMaxRozmiarTablic, List<Int32> UNRTablicaSortowania)
        {

            
            int UNRSeed = 0;
           
            for (int i = 0; i < UNRMaxRozmiarTablic; i++)
            {

                Random UNRRandom = new Random(UNRSeed);
                UNRTablicaSortowania.Add(UNRRandom.Next(UNRDolnaGranica, UNRGornaGranica));
                UNRSeed++;


            }

            return UNRTablicaSortowania;
        }


        //Funkcja zamieniająca listę na tablicę
        public static DataTable UNRConvertListToDataTable(List<Int32> UNRlist)
        {
            
            DataTable UNRtable = new DataTable();


            UNRtable.Columns.Add("Pozycja");
            UNRtable.Columns.Add("Wartość");

            //// Add columns.
            //for (int i = 0; i < 2; i++)
            //{

            //    table.Columns.Add();

            //}


            int UNRn = 0;
            // Dodaj wiersz.
            foreach (var UNRarray in UNRlist)
            {
                //table.Rows.Add(n);
                UNRtable.Rows.Add(UNRn, UNRarray);
                UNRn++;
            }

            return UNRtable;
        }

    }
}
