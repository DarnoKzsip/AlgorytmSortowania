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

        public static DataTable UNRConvertListToDataTableCzasy(List<UNRCzasy> UNRlist)
        {

            DataTable UNRtable = new DataTable();


            UNRtable.Columns.Add("Rozmiar");
            UNRtable.Columns.Add("Czas z Pomiaru");
            UNRtable.Columns.Add("Czas obliczony");

            //// Add columns.
            //for (int i = 0; i < 2; i++)
            //{

            //    table.Columns.Add();

            //}


            int UNRn = 0;
            //UNRtable.Rows.Add(UNRlist[0].UNRGetRozmiar(), UNRlist[0].UNRGetCzasPomiaru());
            // Dodaj wiersz.
            foreach (var UNRarray in UNRlist)
            {
                //table.Rows.Add(n);
                UNRtable.Rows.Add(UNRn, UNRarray.UNRGetCzasPomiaru(), UNRarray.UNRGetCzasObliczony());
                UNRn++;
            }

            return UNRtable;
        }

    }
}
