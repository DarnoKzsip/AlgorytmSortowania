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
        
        public UNRGlowne()
        {
            InitializeComponent();
           

        }

        private void UNRBtnWynikiFormaTabelaryczna_Click(object sender, EventArgs e)
        {
            Int32.TryParse(UNRTBoxMinimalnaProba.Text, out UNRLiczbaPowtorzen); 
            Int32.TryParse(UNRTBoxMaxRozmiarTablic.Text, out UNRMaxRozmiarTablic);
            Int32.TryParse(UNRTBoxDolnaGranicaPrzedzialu.Text, out UNRDolnaGranica);
            Int32.TryParse(UNRTBoxGornaGranicaPrzedzialu.Text, out UNRGornaGranica);
            
            //UNRLiczbaPowtorzen = Convert.ToInt32(UNRTBoxMinimalnaProba.Text);
            //UNRMaxRozmiarTablic = Convert.ToInt32(UNRTBoxMaxRozmiarTablic);
            //UNRDolnaGranica = Convert.ToInt32(UNRTBoxDowolnaGranicaPrzedzialu);
            //UNRGornaGranica = Convert.ToInt32(UNRTBoxGornaGranicaPrzedzialu);

            List<Int32> UNRTablicaSortowania = new List<Int32>();

            for (int i = 1; i < UNRMaxRozmiarTablic; i++) {

                Random UNRRandom = new Random(UNRSeed);
                    UNRTablicaSortowania.Add(UNRRandom.Next(UNRDolnaGranica, UNRGornaGranica));
                    UNRSeed++;


            }

            MessageBox.Show("OK");

            if (UNRShell.Checked == true) {


                UNRShell Shell = new UNRShell(UNRTablicaSortowania);

            }

            else if (UNRGrzebieniowe.Checked == true)
            {

                UNRGrzebieniowe Shell = new UNRGrzebieniowe(UNRTablicaSortowania);

            };

        }
    }
}
