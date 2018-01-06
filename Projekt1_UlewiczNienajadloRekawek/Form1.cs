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
using System.Windows.Forms.DataVisualization.Charting;

namespace Projekt1_UlewiczNienajadloRekawek
{
    public partial class UNRGlowne : Form
    {
        int UNRLiczbaPowtorzen;
        Int32 UNRMaxRozmiarTablic;
        Int32 UNRDolnaGranica;
        Int32 UNRGornaGranica;
        bool UNRFlagaPrzycisku = false; //Znacznik naciśnięcia tablicy w formie tabelarycznej
        List<Int32> UNRTablicaSortowania = new List<Int32>();
        List<Int32> UNRTablicaPoSortowaniu = new List<Int32>();
        List<UNRCzasy> UNRTablicaPomiarowa = new List<UNRCzasy>();
        List<UNRCzasy> UNRTablicaOstateczna = new List<UNRCzasy>();
        DataTable UNRtable;
        
        
        public UNRGlowne()
        {
            InitializeComponent();
            UNRDgvPoSortowaniu.Visible = false;
            UNRDgvPrzedSortowaniem.Visible = false;
            UNRChart.Visible = false;
            KR_Zmien_Styl_linii();
           

        }

        private void UNRBtnWynikiFormaTabelaryczna_Click(object sender, EventArgs e)
        {
            //int start, stop;
            UNRConversionTB();
            UNRLosowanie();
            //int UNROstatecznyRozmiar;
            double UNROstatecznyCzas = 0;
            Stopwatch UNRwatch = new Stopwatch();
            for (int UNRAktRozmiar = 0; UNRAktRozmiar < UNRMaxRozmiarTablic; UNRAktRozmiar++) //generowanie aktualnego rozmiaru tablicy
            {

                for (int UNRProba = 0; UNRProba < UNRLiczbaPowtorzen; UNRProba++) {         //generowanie liczby tablic o danym rozmiarze

                    UNRUtils.UNRLosowanie(UNRDolnaGranica, UNRGornaGranica, UNRAktRozmiar, UNRTablicaSortowania);
                    UNRCzasy UNRczas_sortowania_ob = new UNRCzasy();
                    if (UNRShell.Checked == true) 
                    { 
                    UNRShell UNRShell_ob = new UNRShell(UNRTablicaSortowania);
                    UNRDgvPrzedSortowaniem.Visible = false;
                    UNRwatch.Reset();
                    UNRwatch.Start();
                    UNRTablicaPoSortowaniu = UNRShell_ob.Sortuj();
                    UNRwatch.Stop();
                    UNRczas_sortowania_ob.UNRUstawRozmiar(UNRAktRozmiar);
                    UNRczas_sortowania_ob.UNRUstawCzasPomiaru(1000000 * UNRwatch.ElapsedTicks / Stopwatch.Frequency); //pomiar czasu w mikrosekundach
                    UNRTablicaPomiarowa.Add(UNRczas_sortowania_ob);
                    }
                    if (UNRGrzebieniowe.Checked == true)
                    {
                        UNRGrzebieniowe UNRGrzebieniowe_ob = new UNRGrzebieniowe(UNRTablicaSortowania);
                    UNRDgvPrzedSortowaniem.Visible = false;
                    UNRwatch.Reset();
                    UNRwatch.Start();
                    UNRTablicaPoSortowaniu = UNRGrzebieniowe_ob.Sortuj();
                    UNRwatch.Stop();
                    UNRczas_sortowania_ob.UNRUstawRozmiar(UNRAktRozmiar);
                    UNRczas_sortowania_ob.UNRUstawCzasPomiaru(1000000 * UNRwatch.ElapsedTicks / Stopwatch.Frequency); //pomiar czasu w mikrosekundach
                    UNRTablicaPomiarowa.Add(UNRczas_sortowania_ob);
                    }
                
                }

            }


            for (int UNRi = 1; UNRi < UNRTablicaPomiarowa.Count; UNRi++)
            {

                UNRCzasy UNRCzasy_ostateczne = new UNRCzasy();

                if (UNRTablicaPomiarowa[UNRi].UNRGetRozmiar() == UNRTablicaPomiarowa[UNRi - 1].UNRGetRozmiar())
                {

                    UNROstatecznyCzas = UNROstatecznyCzas + UNRTablicaPomiarowa[UNRi].UNRGetCzasPomiaru();

                }
                else
                {

                    UNROstatecznyCzas = UNROstatecznyCzas / UNRLiczbaPowtorzen;
                    UNRCzasy_ostateczne.UNRUstawCzasPomiaru(UNROstatecznyCzas);
                    UNRCzasy_ostateczne.UNRUstawRozmiar(UNRTablicaPomiarowa[UNRi].UNRGetRozmiar());
                    UNRTablicaOstateczna.Add(UNRCzasy_ostateczne);
                    UNROstatecznyCzas = 0;
                }
            }

            UNRtable = UNRUtils.UNRConvertListToDataTableCzasy(UNRTablicaOstateczna);
            UNRDgvPoSortowaniu.DataSource = UNRtable;
            UNRDgvPoSortowaniu.Visible = true;

            UNRFlagaPrzycisku = true;
            
            

        }

        private void UNRBtnWynikiFormaWykresu_Click(object sender, EventArgs e)
        {
            UNRDgvPoSortowaniu.Visible = false;
            UNRDgvPrzedSortowaniem.Visible = false;
            UNRChart.Visible = true;

            if (UNRFlagaPrzycisku == false)
            {
                UNRBtnWynikiFormaTabelaryczna_Click(sender, e);
            }

            int[] UNRWykresWielkosci = new int[UNRTablicaOstateczna.Count];
            double[] UNRWykresPomiaru = new double[UNRTablicaOstateczna.Count]; ;

            for (int UNRi = 0; UNRi < UNRTablicaOstateczna.Count; UNRi++)
            {
                UNRWykresWielkosci[UNRi] = UNRTablicaOstateczna[UNRi].UNRGetRozmiar();
                UNRWykresPomiaru[UNRi] = UNRTablicaOstateczna[UNRi].UNRGetCzasPomiaru();


            }

            UNRChart.Series[0].ChartType = SeriesChartType.Line;
            UNRChart.Series[0].BorderDashStyle = ChartDashStyle.Solid;
            UNRChart.Titles.Add("Wykres pomiaru");
            UNRChart.BackColor = UNRTBoxWziernikKoloruTla.BackColor; //Ustalenie tła wykresu
            UNRChart.Series[0].Name = "Pomiar pomierzony";  //Ustalenie nazwy dla wykresu
            UNRChart.Series[0].Color = UNRTBoxWziernikKoloruLinii.BackColor; //Ustalenie koloru linii
            UNRChart.Series[0].BorderWidth = Convert.ToInt16(UNRTBoxUstalonaGrubośćLiniiLiczbowo.Text);

            switch (UNRComboBoxUstalStylLiniiWykresu.SelectedIndex) //Wybór stylu linii ze zdefiniowanych wzorców
            {
                case 0: UNRChart.Series[0].BorderDashStyle = ChartDashStyle.Solid;
                    break;
                case 1: UNRChart.Series[0].BorderDashStyle = ChartDashStyle.Dash;
                    break;
                case 2: UNRChart.Series[0].BorderDashStyle = ChartDashStyle.Dot;
                    break;
                case 3: UNRChart.Series[0].BorderDashStyle = ChartDashStyle.DashDot;
                    break;
                case 4: UNRChart.Series[0].BorderDashStyle = ChartDashStyle.DashDotDot;
                    break;
                case 5: UNRChart.Series[0].BorderDashStyle = ChartDashStyle.Solid;
                    break;
                default: UNRChart.Series[0].BorderDashStyle = ChartDashStyle.Solid;
                    break;
            }

            UNRChart.Series[0].Points.DataBindXY(UNRWykresWielkosci, UNRWykresPomiaru);
            MessageBox.Show("ok");
        }

        private void UNRBtnWizualizacjaTablicyPrzedSortowaniem_Click(object sender, EventArgs e)
        {
                
                UNRLosowanie();
                var UNRListToSee = new BindingList<Int32>(UNRTablicaSortowania);
                DataTable table = UNRUtils.UNRConvertListToDataTable(UNRTablicaSortowania);
                UNRDgvPrzedSortowaniem.DataSource = table;
                UNRDgvPrzedSortowaniem.Visible = true;
           
             
        }

        private void UNRLosowanie() {

            UNRConversionTB();
            //Utwórz losową tablicę
            UNRTablicaSortowania = UNRUtils.UNRLosowanie(UNRDolnaGranica, UNRGornaGranica, UNRMaxRozmiarTablic, UNRTablicaSortowania);

     
        
        }

         private void UNRBtnWizualizacjaTablicyPoSortowaniem_Click(object sender, EventArgs e)
         {
             UNRConversionTB();

             if (UNRShell.Checked == true)
             {


                 UNRShell Shell = new UNRShell(UNRTablicaSortowania);
                 UNRDgvPrzedSortowaniem.Visible = false;               
                 UNRTablicaPoSortowaniu = Shell.Sortuj();
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

        void KR_Zmien_Styl_linii()
        {

            UNRPanPodgladWykresu.Controls.Clear();
            Graphics UNRg = UNRPanPodgladWykresu.CreateGraphics();

            Pen UNRMyPen = new Pen(UNRTBoxWziernikKoloruLinii.BackColor, Convert.ToSingle(UNRTBarZmieńGrubośćLinii.Value));
            switch (UNRComboBoxUstalStylLiniiWykresu.SelectedIndex)
            {
                case 1: UNRMyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    break;
                case 2: UNRMyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    break;
                case 3: UNRMyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                    break;
                case 4: UNRMyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
                    break;
                case 5: UNRMyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    break;
                default: UNRMyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    break;
            }
            UNRg.Clear(UNRTBoxWziernikKoloruTla.BackColor);
            Pen KR_Black_Pen = new Pen(Color.Black, 1);
            Rectangle KR_rect = new Rectangle(0, 10, 100, 20);
            UNRg.DrawRectangle(KR_Black_Pen, KR_rect);
            SolidBrush KR_solid = new SolidBrush(Color.White);
            UNRg.FillRectangle(KR_solid, KR_rect);
            UNRg.DrawLine(UNRMyPen, 0, 20, 100, 20);
        
        }

         private void UNRBtnWybierzKolorLinii_Click(object sender, EventArgs e)
         {
              ColorDialog UNRokienkoKoloru = new ColorDialog();
            if (UNRokienkoKoloru.ShowDialog() == DialogResult.OK)
            {
                UNRTBoxWziernikKoloruLinii.BackColor = UNRokienkoKoloru.Color;
            }

            KR_Zmien_Styl_linii();
        }

        private void UNRBtnWybierzKolorTła_Click(object sender, EventArgs e)
        {
         ColorDialog UNRokienkoKoloru = new ColorDialog();
            if (UNRokienkoKoloru.ShowDialog() == DialogResult.OK)
            {
                UNRTBoxWziernikKoloruTla.BackColor = UNRokienkoKoloru.Color;
            }

            KR_Zmien_Styl_linii();
        }

        private void UNRTBarZmieńGrubośćLinii_Scroll(object sender, EventArgs e)
        {
            UNRTBoxUstalonaGrubośćLiniiLiczbowo.Text = Convert.ToString(UNRTBarZmieńGrubośćLinii.Value);
            KR_Zmien_Styl_linii();
        }

        private void UNRTBoxUstalonaGrubośćLiniiLiczbowo_TextChanged(object sender, EventArgs e)
        {
            UNRTBarZmieńGrubośćLinii.Value = Convert.ToInt16(UNRTBoxUstalonaGrubośćLiniiLiczbowo.Text);
            KR_Zmien_Styl_linii();
        }

        private void UNRComboBoxUstalStylLiniiWykresu_SelectedValueChanged(object sender, EventArgs e)
        {
            KR_Zmien_Styl_linii();
        }

        private void UNRBtnResetuj_Click(object sender, EventArgs e)
        {

        }

        private void UNRBtnDemo_Click(object sender, EventArgs e)
        {
            if (UNRShell.Checked == true) { 
            UNRShellDemo UNRShellDemo = new Projekt1_UlewiczNienajadloRekawek.UNRShellDemo();
            UNRShellDemo.Show();
            }

            if (UNRGrzebieniowe.Checked == true) {

                UNRComboSort UNRComboDemo = new Projekt1_UlewiczNienajadloRekawek.UNRComboSort();
                UNRComboDemo.Show();
            
            }
        }
         }

        
    }
