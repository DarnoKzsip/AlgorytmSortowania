using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_UlewiczNienajadloRekawek
{
    class UNRGrzebieniowe
    {
        List<int> UNRTablicaPrzedSortowaniem;
        List<int> UNRTablicaPoSortowaniu;
        double UNRgap;

        public UNRGrzebieniowe(List<int> UNRTablicaPrzedSortowaniem)
        {

            this.UNRTablicaPrzedSortowaniem = UNRTablicaPrzedSortowaniem;

        }

        internal List<int> Sortuj()
        {

            double UNRgap = UNRTablicaPrzedSortowaniem.Count;
            bool UNRswaps = true;

            while (UNRgap > 1 || UNRswaps)
            {
                UNRgap /= 1.247330950103979;
                if (UNRgap < 1)
                    UNRgap = 1;
                int UNRi = 0;
                UNRswaps = false;
                while (UNRi < UNRTablicaPrzedSortowaniem.Count - UNRgap) //(UNRi + UNRgap < UNRTablicaPrzedSortowaniem.Count)
                {

                    int UNRigap = UNRi + (int)UNRgap;
                    if (UNRTablicaPrzedSortowaniem[UNRi] < UNRTablicaPrzedSortowaniem[UNRigap]) //(UNRTablicaPrzedSortowaniem[UNRi] > UNRTablicaPrzedSortowaniem[UNRigap])
                    {

                        int URNtmp = UNRTablicaPrzedSortowaniem[UNRi];
                        UNRTablicaPrzedSortowaniem[UNRi] = UNRTablicaPrzedSortowaniem[UNRigap];
                        UNRTablicaPrzedSortowaniem[UNRigap] = URNtmp;
                        UNRswaps = true;

                    }
                    UNRi++;

                    

                }

                this.UNRTablicaPoSortowaniu = UNRTablicaPrzedSortowaniem;
            }
            return this.UNRTablicaPoSortowaniu;
        }
    }
}
