using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt1_UlewiczNienajadloRekawek
{
    public partial class UNRGlowne : Form
    {
        int UNRLiczbaPowtorzen;
        Int32 UNRMaxRozmiarTablic;
        Int32 UNRDolnaGranica;
        Int32 UNRGornaGranica;
        //int UNRSeed = 0; // inicjator wartości Random(bez wstawiania tych samych wartości ze względu na Timestamp)
        List<Int32> UNRTablicaSortowania = new List<Int32>();
        List<Int32> UNRTablicaPoSortowaniu = new List<Int32>();
        List<UNRCzasy> UNRTablicaPomiarowa = new List<UNRCzasy>();
        Stopwatch watch = new Stopwatch();
        
        public UNRGlowne()
        {
            InitializeComponent();
            UNRDgvPoSortowaniu.Visible = false;
            UNRDgvPrzedSortowaniem.Visible = false;
           

        }

        private void UNRBtnWynikiFormaTabelaryczna_Click(object sender, EventArgs e)
        {
            UNRConversionTB();
            UNRLosowanie();
            for (int UNRAktRozmiar = 0; UNRAktRozmiar < UNRMaxRozmiarTablic; UNRAktRozmiar++) //generowanie aktualnego rozmiaru tablicy
            {

                for (int UNRProba = 0; UNRProba < UNRLiczbaPowtorzen; UNRProba++) {         //generowanie liczby tablic o danym rozmiarze

                    UNRUtils.UNRLosowanie(UNRDolnaGranica, UNRGornaGranica, UNRAktRozmiar, UNRTablicaSortowania);
                    UNRShell Shell = new UNRShell(UNRTablicaSortowania);
                    UNRCzasy czas_sortowania = new UNRCzasy();
                    UNRDgvPrzedSortowaniem.Visible = false;
                    watch.Reset();
                    watch.Start();
                    UNRTablicaPoSortowaniu = Shell.Sortuj();
                    watch.Stop();
                    czas_sortowania.UNRUstawRozmiar(UNRAktRozmiar);
                    czas_sortowania.UNRUstawCzasPomiaru(watch.ElapsedTicks);
                    UNRTablicaPomiarowa.Add(czas_sortowania);
                    //var UNRListToSee = new BindingList<Int32>(UNRTablicaPoSortowaniu);
                    //DataTable table = UNRUtils.UNRConvertListToDataTable(UNRTablicaPoSortowaniu);
                    //UNRDgvPoSortowaniu.DataSource = table;
                    //UNRDgvPoSortowaniu.Visible = true;
                
                }

            }

            MessageBox.Show("ok");
                

            //if (UNRShell.Checked == true)
            //{


            //    UNRShell Shell = new UNRShell(UNRTablicaSortowania);
            //    UNRDgvPrzedSortowaniem.Visible = false;
            //    watch.Start();
            //    UNRTablicaPoSortowaniu = Shell.Sortuj();
            //    watch.Stop();
            //    var UNRListToSee = new BindingList<Int32>(UNRTablicaPoSortowaniu);
            //    DataTable table = UNRUtils.UNRConvertListToDataTable(UNRTablicaPoSortowaniu);
            //    UNRDgvPoSortowaniu.DataSource = table;
            //    UNRDgvPoSortowaniu.Visible = true;


            //}
            

        }

        private void UNRBtnWizualizacjaTablicyPrzedSortowaniem_Click(object sender, EventArgs e)
        {
                
                UNRLosowanie();
               // UNRRandomArray UNR_PokazTablice = new UNRRandomArray(Int32.TryParse(UNRTBoxDolnaGranicaPrzedzialu.Text, out UNRDolnaGranica))
                //UNRTablicaSortowania
                var UNRListToSee = new BindingList<Int32>(UNRTablicaSortowania);
                DataTable table = UNRUtils.UNRConvertListToDataTable(UNRTablicaSortowania);
                UNRDgvPrzedSortowaniem.DataSource = table;
                //UNRDgvPrzedSortowaniem.DataSource = UNRListToSee;
                UNRDgvPrzedSortowaniem.Visible = true;
           
             
        }

        private void UNRLosowanie() {

            UNRConversionTB();
            //Int32.TryParse(UNRTBoxMinimalnaProba.Text, out UNRLiczbaPowtorzen);
            //Int32.TryParse(UNRTBoxMaxRozmiarTablic.Text, out UNRMaxRozmiarTablic);
            //Int32.TryParse(UNRTBoxDolnaGranicaPrzedzialu.Text, out UNRDolnaGranica);
            //Int32.TryParse(UNRTBoxGornaGranicaPrzedzialu.Text, out UNRGornaGranica);

            //Utwórz losową tablicę
            UNRTablicaSortowania = UNRUtils.UNRLosowanie(UNRDolnaGranica, UNRGornaGranica, UNRMaxRozmiarTablic, UNRTablicaSortowania);

            //Wybierz rodzaj obiektu jakim ma być losowana tablica
            //if (UNRShell.Checked == true)
            //{


            //    UNRShell Shell = new UNRShell(UNRTablicaSortowania);

            //}

            //else if (UNRGrzebieniowe.Checked == true)
            //{

            //    UNRGrzebieniowe Grzebieniowe = new UNRGrzebieniowe(UNRTablicaSortowania);

            //};
        
        
        }

         private void UNRBtnWizualizacjaTablicyPoSortowaniem_Click(object sender, EventArgs e)
         {
             UNRConversionTB();

             if (UNRShell.Checked == true)
             {


                 UNRShell Shell = new UNRShell(UNRTablicaSortowania);
                 UNRDgvPrzedSortowaniem.Visible = false;
                 watch.Start();
                 UNRTablicaPoSortowaniu = Shell.Sortuj();
                 watch.Stop();
                 var UNRListToSee = new BindingList<Int32>(UNRTablicaPoSortowaniu);
                 DataTable table = UNRUtils.UNRConvertListToDataTable(UNRTablicaPoSortowaniu);
                 UNRDgvPoSortowaniu.DataSource = table;
                 UNRDgvPoSortowaniu.Visible = true;
                 

             }

             else if (UNRGrzebieniowe.Checked == true)
             {

                 UNRGrzebieniowe Grzebieniowe = new UNRGrzebieniowe(UNRTablicaSortowania);
                 UNRDgvPrzedSortowaniem.Visible = false;

                 UNRTablicaPoSortowaniu = Grzebieniowe.Sortuj();
                 var UNRListToSee = new BindingList<Int32>(UNRTablicaPoSortowaniu);
                 DataTable table = UNRUtils.UNRConvertListToDataTable(UNRTablicaPoSortowaniu);
                 UNRDgvPoSortowaniu.DataSource = table;
                 UNRDgvPoSortowaniu.Visible = true;
             };
        
         }

         private bool UNRConversionTB() {

             Int32.TryParse(UNRTBoxMinimalnaProba.Text, out UNRLiczbaPowtorzen);
             Int32.TryParse(UNRTBoxMaxRozmiarTablic.Text, out UNRMaxRozmiarTablic);
             Int32.TryParse(UNRTBoxDolnaGranicaPrzedzialu.Text, out UNRDolnaGranica);
             Int32.TryParse(UNRTBoxGornaGranicaPrzedzialu.Text, out UNRGornaGranica);

             return true;
         }
    }
}
