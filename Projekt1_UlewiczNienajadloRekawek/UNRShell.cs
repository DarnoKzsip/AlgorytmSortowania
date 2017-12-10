using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_UlewiczNienajadloRekawek
{
    class UNRShell
    {
        List<UNRListaPo> UNRTablicaPrzedSortowaniem;
        List<UNRListaPo> UNRTablicaPoSortowaniu;
        Stopwatch watch = new Stopwatch();

        public UNRShell(List<UNRListaPo> UNRTablicaPrzedSortowaniem)
        {

            this.UNRTablicaPrzedSortowaniem = UNRTablicaPrzedSortowaniem;

        }


        internal List<UNRListaPo> Sortuj()
        {
            int UNRgap = (UNRTablicaPrzedSortowaniem.Count / 2);
            watch.Start();
            while (UNRgap > 0)
            {

                for (int UNRi = 0; UNRi + UNRgap < UNRTablicaPrzedSortowaniem.Count; UNRi++) // (int UNRi = 0; UNRi  < UNRTablicaPrzedSortowaniem.Count - UNRgap; UNRi++) - sortowanie malejąco
                {

                    int UNRj = UNRi + UNRgap;
                    int UNRtmp = UNRTablicaPrzedSortowaniem[UNRj].UNRElement;
                    while (UNRj - UNRgap >= 0 && UNRtmp < UNRTablicaPrzedSortowaniem[UNRj - UNRgap].UNRElement) //(UNRj >= UNRgap && UNRtmp > UNRTablicaPrzedSortowaniem[UNRj - UNRgap]) - sortowanie malejąco
                    {
                        UNRTablicaPrzedSortowaniem[UNRj].UNRElement = UNRTablicaPrzedSortowaniem[UNRj - UNRgap].UNRElement;
                        UNRj -= UNRgap;
                    }
                    UNRTablicaPrzedSortowaniem[UNRj].UNRElement = UNRtmp;
                    UNRTablicaPoSortowaniu[UNRi].UNRCzas = Convert.ToInt32(watch.ElapsedMilliseconds);
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
            watch.Stop();
            watch.Reset();

            this.UNRTablicaPoSortowaniu = UNRTablicaPrzedSortowaniem;
            return this.UNRTablicaPoSortowaniu;
        }
    }
}
