using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_UlewiczNienajadloRekawek
{
    class UNRShell
    {
        List<int> UNRTablicaPrzedSortowaniem;
        List<int> UNRTablicaPoSortowaniu;

        public UNRShell(List<int> UNRTablicaPrzedSortowaniem)
        {

            this.UNRTablicaPrzedSortowaniem = UNRTablicaPrzedSortowaniem;

        }


        internal List<int> Sortuj()
        {
            int UNRgap = (UNRTablicaPrzedSortowaniem.Count / 2);

            while (UNRgap > 0)
            {
                for (int UNRi = 0; UNRi + UNRgap < UNRTablicaPrzedSortowaniem.Count; UNRi++) // (int UNRi = 0; UNRi  < UNRTablicaPrzedSortowaniem.Count - UNRgap; UNRi++) - sortowanie malejąco
                {

                    int UNRj = UNRi + UNRgap;
                    int UNRtmp = UNRTablicaPrzedSortowaniem[UNRj];
                    while (UNRj - UNRgap >= 0 && UNRtmp < UNRTablicaPrzedSortowaniem[UNRj-UNRgap]) //(UNRj >= UNRgap && UNRtmp > UNRTablicaPrzedSortowaniem[UNRj - UNRgap]) - sortowanie malejąco
                    {
                        UNRTablicaPrzedSortowaniem[UNRj] = UNRTablicaPrzedSortowaniem[UNRj - UNRgap];
                        UNRj -= UNRgap;
                    }
                    UNRTablicaPrzedSortowaniem[UNRj] = UNRtmp;
                }
                if (UNRgap == 2) //zmień rozmiar gap
                {

                    UNRgap = 1;

                }
                else
                {

                    UNRgap = (int)(UNRgap / 2.2);

                }

            }

            this.UNRTablicaPoSortowaniu = UNRTablicaPrzedSortowaniem;
            return this.UNRTablicaPoSortowaniu;
        }
    }
}
