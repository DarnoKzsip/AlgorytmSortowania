using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_UlewiczNienajadloRekawek
{
    class UNRGrzebieniowe
    {
        List<UNRListaPo> UNRTablicaPrzedSortowaniem;
        List<UNRListaPo> UNRTablicaPoSortowaniu;
        //double UNRgap;
        Stopwatch watch = new Stopwatch();

        public UNRGrzebieniowe(List<UNRListaPo> UNRTablicaPrzedSortowaniem)
        {

            this.UNRTablicaPrzedSortowaniem = UNRTablicaPrzedSortowaniem;

        }

        internal List<UNRListaPo> Sortuj()
        {

            double UNRgap = UNRTablicaPrzedSortowaniem.Count;
            bool UNRswaps = true;

            watch.Start();
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
                    if (UNRTablicaPrzedSortowaniem[UNRi].UNRElement < UNRTablicaPrzedSortowaniem[UNRigap].UNRElement) //(UNRTablicaPrzedSortowaniem[UNRi] > UNRTablicaPrzedSortowaniem[UNRigap])
                    {

                        int URNtmp = UNRTablicaPrzedSortowaniem[UNRi].UNRElement;
                        UNRTablicaPrzedSortowaniem[UNRi].UNRElement = UNRTablicaPrzedSortowaniem[UNRigap].UNRElement;
                        UNRTablicaPrzedSortowaniem[UNRigap].UNRElement = URNtmp;
                        UNRswaps = true;
                        UNRTablicaPrzedSortowaniem[UNRi].UNRCzas = Convert.ToInt32(watch.ElapsedTicks);

                    }
                   // UNRTablicaPrzedSortowaniem[UNRi].UNRCzas = Convert.ToInt32(watch.ElapsedMilliseconds);
                    UNRi++;



                }

                
            }
            this.UNRTablicaPoSortowaniu = UNRTablicaPrzedSortowaniem;
            watch.Stop();
            watch.Reset();

            return this.UNRTablicaPoSortowaniu;
        }
    }
}
