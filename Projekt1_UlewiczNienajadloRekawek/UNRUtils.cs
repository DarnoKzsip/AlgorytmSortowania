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

            Random UNRRandomseed = new Random();
            int UNRSeed = Convert.ToInt32(UNRRandomseed.Next(0, 1000));
           
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

            int UNRn = 0;
            // Dodaj wiersz.
            foreach (var UNRarray in UNRlist)
            {
                UNRtable.Rows.Add(UNRn, UNRarray);
                UNRn++;
            }

            return UNRtable;
        }

        public static DataTable UNRConvertListToDataTableCzasy(List<UNRCzasy> UNRlist)
        {

            DataTable UNRtable = new DataTable();


            UNRtable.Columns.Add("Rozmiar");
            UNRtable.Columns.Add("Czas z pomiaru");
            UNRtable.Columns.Add("Czas obliczony");

            int UNRn = 0;
            // Dodaj wiersz.
            foreach (var UNRarray in UNRlist)
            {
                UNRtable.Rows.Add(UNRn, UNRarray.UNRGetCzasPomiaru(), UNRarray.UNRGetCzasObliczony());
                UNRn++;
            }

            return UNRtable;
        }

    }
}
