using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        int UNRSeed = 0; // inicjator wartości Random(bez wstawiania tych samych wartości ze względu na Timestamp)
        List<UNRListaPo> UNRTablicaSortowania = new List<UNRListaPo>();
        List<UNRListaPo> UNRTablicaPoSortowaniu = new List<UNRListaPo>();
        

        
        public UNRGlowne()
        {
            InitializeComponent();
            UNRDgvPrzedSortowaniem.Visible = false;
            UNRDgvPoSortowaniu.Visible = false;
           

        }

        public bool UNREPCheckLiczbaProb { 
        
           
           if (UNRTBoxMinimalnaProba.Text = "")
           {

               UNRTBoxMinimalnaProba.SetError(Tb_Imie, "Podaj liczbę prób");
               return false;

           }

           else
           {

               EP_Error.Dispose();

           }
        
            return true;
        }

        private void UNRBtnWynikiFormaTabelaryczna_Click(object sender, EventArgs e)
        {
            UNRLosowanie();
            

        }

        private void UNRBtnWizualizacjaTablicyPrzedSortowaniem_Click(object sender, EventArgs e)
        {
                UNRLosowanie();

                //var UNRListToSee = new BindingList<Int32>(UNRTablicaSortowania);
                DataTable table = ConvertListToDataTable(UNRTablicaSortowania);
                UNRDgvPrzedSortowaniem.DataSource = table;
                //UNRDgvPrzedSortowaniem.DataSource = UNRListToSee;
                UNRDgvPrzedSortowaniem.Visible = true;
                UNRPBsalsa.Visible = false;
           
             
        }

        private void UNRLosowanie() {

            Int32.TryParse(UNRTBoxMinimalnaProba.Text, out UNRLiczbaPowtorzen);
            Int32.TryParse(UNRTBoxMaxRozmiarTablic.Text, out UNRMaxRozmiarTablic);
            Int32.TryParse(UNRTBoxDolnaGranicaPrzedzialu.Text, out UNRDolnaGranica);
            Int32.TryParse(UNRTBoxGornaGranicaPrzedzialu.Text, out UNRGornaGranica);

            //UNRLiczbaPowtorzen = Convert.ToInt32(UNRTBoxMinimalnaProba.Text);
            //UNRMaxRozmiarTablic = Convert.ToInt32(UNRTBoxMaxRozmiarTablic);
            //UNRDolnaGranica = Convert.ToInt32(UNRTBoxDowolnaGranicaPrzedzialu);
            //UNRGornaGranica = Convert.ToInt32(UNRTBoxGornaGranicaPrzedzialu);


            //for (int UNR_l = 0; UNR_l < UNRLiczbaPowtorzen; UNR_l++) //ilość powtórzeń
            //{
                for (int i = 1; i < UNRMaxRozmiarTablic; i++) //ilość wylosowanych cyfr
                {

                    Random UNRRandom = new Random(UNRSeed);
                    UNRListaPo UNRDodanyElement = new UNRListaPo();
                    UNRDodanyElement.UNRElement = UNRRandom.Next(UNRDolnaGranica, UNRGornaGranica);
                    UNRDodanyElement.UNRCzas = 0;
                    UNRTablicaSortowania.Add(UNRDodanyElement);
                    UNRSeed++;

                    if (UNRShell.Checked == true)
                    {


                        UNRShell Shell_UNR_l = new UNRShell(UNRTablicaSortowania);

                    }

                    else if (UNRGrzebieniowe.Checked == true)
                    {

                        UNRGrzebieniowe Grzebieniowe_UNR_l = new UNRGrzebieniowe(UNRTablicaSortowania);

                    };


                }
        

            //MessageBox.Show("OK");

           

           // };
        
        }

        
        //TODO: Zmienić nazwy zmiennych w funkcji conversji Listy na tablicę do zasilania DGV 


        DataTable ConvertListToDataTable(List<UNRListaPo> list)
        {
            // New table.
            DataTable table = new DataTable();


            table.Columns.Add("Pozycja");
            table.Columns.Add("Przed Losowaniem");
            table.Columns.Add("Czas");

            //// Add columns.
            //for (int i = 0; i < 2; i++)
            //{

            //    table.Columns.Add();

            //}

            
            int n = 0;
            // Add rows.
            foreach (var array in list)
            {
                //table.Rows.Add(n);
                table.Rows.Add(n,array.UNRElement,array.UNRCzas);
                n++;
            }

            return table;
        }

         private void UNRBtnWizualizacjaTablicyPoSortowaniem_Click(object sender, EventArgs e)
         {
             if (UNRShell.Checked == true)
             {


                 UNRShell Shell_UNR_l = new UNRShell(UNRTablicaSortowania);
                 UNRDgvPrzedSortowaniem.Visible = false;
                 UNRTablicaPoSortowaniu = Shell_UNR_l.Sortuj();
                 var UNRListToSee = new BindingList<UNRListaPo>(UNRTablicaPoSortowaniu);
                 DataTable table = ConvertListToDataTable(UNRTablicaPoSortowaniu);
                 UNRDgvPoSortowaniu.DataSource = table;
                 UNRDgvPoSortowaniu.Visible = true;
                 UNRPBsalsa.Visible = false;


             }

             else if (UNRGrzebieniowe.Checked == true)
             {

                 UNRGrzebieniowe Grzebieniowe_UNR_l = new UNRGrzebieniowe(UNRTablicaSortowania);
                 UNRDgvPrzedSortowaniem.Visible = false;
                 UNRTablicaPoSortowaniu = Grzebieniowe_UNR_l.Sortuj();
                 var UNRListToSee = new BindingList<UNRListaPo>(UNRTablicaPoSortowaniu);
                 DataTable table = ConvertListToDataTable(UNRTablicaPoSortowaniu);
                 UNRDgvPoSortowaniu.DataSource = table;
                 UNRDgvPoSortowaniu.Visible = true;
                 UNRPBsalsa.Visible = false;
             };

         }
    }
}
