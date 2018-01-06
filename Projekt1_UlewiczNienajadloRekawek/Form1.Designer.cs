namespace Projekt1_UlewiczNienajadloRekawek
{
    partial class UNRGlowne
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.UNRBtnWybierzKolorLinii = new System.Windows.Forms.Button();
            this.UNRBtnWybierzKolorTła = new System.Windows.Forms.Button();
            this.UNRTBoxWziernikKoloruLinii = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UNRTBoxWziernikKoloruTla = new System.Windows.Forms.TextBox();
            this.UNRComboBoxUstalStylLiniiWykresu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UNRTBarZmieńGrubośćLinii = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.UNRTBoxUstalonaGrubośćLiniiLiczbowo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UNRTBoxMinimalnaProba = new System.Windows.Forms.TextBox();
            this.UNRTBoxMaxRozmiarTablic = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UNRTBoxDolnaGranicaPrzedzialu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UNRTBoxGornaGranicaPrzedzialu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.UNRBtnWynikiFormaTabelaryczna = new System.Windows.Forms.Button();
            this.UNRBtnWynikiFormaWykresu = new System.Windows.Forms.Button();
            this.UNRBtnResetuj = new System.Windows.Forms.Button();
            this.UNRBtnDemo = new System.Windows.Forms.Button();
            this.UNRBtnWizualizacjaTablicyPrzedSortowaniem = new System.Windows.Forms.Button();
            this.UNRBtnWizualizacjaTablicyPoSortowaniem = new System.Windows.Forms.Button();
            this.UNRGrzebieniowe = new System.Windows.Forms.RadioButton();
            this.UNRShell = new System.Windows.Forms.RadioButton();
            this.UNRDgvPrzedSortowaniem = new System.Windows.Forms.DataGridView();
            this.UNRDgvPoSortowaniu = new System.Windows.Forms.DataGridView();
            this.UNRChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.UNRPanPodgladWykresu = new System.Windows.Forms.Panel();
            this.UNREP_Sprawdz = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UNRTBarZmieńGrubośćLinii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNRDgvPrzedSortowaniem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNRDgvPoSortowaniu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNRChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNREP_Sprawdz)).BeginInit();
            this.SuspendLayout();
            // 
            // UNRBtnWybierzKolorLinii
            // 
            this.UNRBtnWybierzKolorLinii.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.UNRBtnWybierzKolorLinii.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UNRBtnWybierzKolorLinii.Location = new System.Drawing.Point(55, 38);
            this.UNRBtnWybierzKolorLinii.Margin = new System.Windows.Forms.Padding(4);
            this.UNRBtnWybierzKolorLinii.Name = "UNRBtnWybierzKolorLinii";
            this.UNRBtnWybierzKolorLinii.Size = new System.Drawing.Size(92, 65);
            this.UNRBtnWybierzKolorLinii.TabIndex = 0;
            this.UNRBtnWybierzKolorLinii.Text = "Wybierz kolor linii\r\n";
            this.UNRBtnWybierzKolorLinii.UseVisualStyleBackColor = true;
            this.UNRBtnWybierzKolorLinii.Click += new System.EventHandler(this.UNRBtnWybierzKolorLinii_Click);
            // 
            // UNRBtnWybierzKolorTła
            // 
            this.UNRBtnWybierzKolorTła.Location = new System.Drawing.Point(344, 37);
            this.UNRBtnWybierzKolorTła.Margin = new System.Windows.Forms.Padding(4);
            this.UNRBtnWybierzKolorTła.Name = "UNRBtnWybierzKolorTła";
            this.UNRBtnWybierzKolorTła.Size = new System.Drawing.Size(122, 65);
            this.UNRBtnWybierzKolorTła.TabIndex = 1;
            this.UNRBtnWybierzKolorTła.Text = "Wybierz kolor tła dla obszaru wykresu";
            this.UNRBtnWybierzKolorTła.UseVisualStyleBackColor = true;
            this.UNRBtnWybierzKolorTła.Click += new System.EventHandler(this.UNRBtnWybierzKolorTła_Click);
            // 
            // UNRTBoxWziernikKoloruLinii
            // 
            this.UNRTBoxWziernikKoloruLinii.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UNRTBoxWziernikKoloruLinii.Location = new System.Drawing.Point(192, 80);
            this.UNRTBoxWziernikKoloruLinii.Margin = new System.Windows.Forms.Padding(4);
            this.UNRTBoxWziernikKoloruLinii.Name = "UNRTBoxWziernikKoloruLinii";
            this.UNRTBoxWziernikKoloruLinii.Size = new System.Drawing.Size(109, 20);
            this.UNRTBoxWziernikKoloruLinii.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wziernik koloru linii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wziernik koloru tła \r\n      dla wykresu";
            // 
            // UNRTBoxWziernikKoloruTla
            // 
            this.UNRTBoxWziernikKoloruTla.Location = new System.Drawing.Point(526, 80);
            this.UNRTBoxWziernikKoloruTla.Margin = new System.Windows.Forms.Padding(4);
            this.UNRTBoxWziernikKoloruTla.Name = "UNRTBoxWziernikKoloruTla";
            this.UNRTBoxWziernikKoloruTla.Size = new System.Drawing.Size(112, 20);
            this.UNRTBoxWziernikKoloruTla.TabIndex = 5;
            // 
            // UNRComboBoxUstalStylLiniiWykresu
            // 
            this.UNRComboBoxUstalStylLiniiWykresu.FormattingEnabled = true;
            this.UNRComboBoxUstalStylLiniiWykresu.Items.AddRange(new object[] {
            "Nie ustawiony",
            "---------------",
            ".........................",
            ".-.-.-.-.-.-.-.-.-.",
            "-..-..-..-..-..-..-..",
            "_______________"});
            this.UNRComboBoxUstalStylLiniiWykresu.Location = new System.Drawing.Point(718, 80);
            this.UNRComboBoxUstalStylLiniiWykresu.Margin = new System.Windows.Forms.Padding(4);
            this.UNRComboBoxUstalStylLiniiWykresu.Name = "UNRComboBoxUstalStylLiniiWykresu";
            this.UNRComboBoxUstalStylLiniiWykresu.Size = new System.Drawing.Size(140, 22);
            this.UNRComboBoxUstalStylLiniiWykresu.TabIndex = 6;
            this.UNRComboBoxUstalStylLiniiWykresu.Text = "Wybor stylu linii";
            this.UNRComboBoxUstalStylLiniiWykresu.SelectedValueChanged += new System.EventHandler(this.UNRComboBoxUstalStylLiniiWykresu_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ustal styl linii wykresu";
            // 
            // UNRTBarZmieńGrubośćLinii
            // 
            this.UNRTBarZmieńGrubośćLinii.Location = new System.Drawing.Point(1014, 80);
            this.UNRTBarZmieńGrubośćLinii.Margin = new System.Windows.Forms.Padding(4);
            this.UNRTBarZmieńGrubośćLinii.Maximum = 12;
            this.UNRTBarZmieńGrubośćLinii.Minimum = 1;
            this.UNRTBarZmieńGrubośćLinii.Name = "UNRTBarZmieńGrubośćLinii";
            this.UNRTBarZmieńGrubośćLinii.Size = new System.Drawing.Size(122, 45);
            this.UNRTBarZmieńGrubośćLinii.TabIndex = 8;
            this.UNRTBarZmieńGrubośćLinii.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.UNRTBarZmieńGrubośćLinii.Value = 1;
            this.UNRTBarZmieńGrubośćLinii.Scroll += new System.EventHandler(this.UNRTBarZmieńGrubośćLinii_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1011, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zmień grubość linii\r\n         wykresu";
            // 
            // UNRTBoxUstalonaGrubośćLiniiLiczbowo
            // 
            this.UNRTBoxUstalonaGrubośćLiniiLiczbowo.Location = new System.Drawing.Point(1014, 183);
            this.UNRTBoxUstalonaGrubośćLiniiLiczbowo.Margin = new System.Windows.Forms.Padding(4);
            this.UNRTBoxUstalonaGrubośćLiniiLiczbowo.Name = "UNRTBoxUstalonaGrubośćLiniiLiczbowo";
            this.UNRTBoxUstalonaGrubośćLiniiLiczbowo.Size = new System.Drawing.Size(127, 20);
            this.UNRTBoxUstalonaGrubośćLiniiLiczbowo.TabIndex = 10;
            this.UNRTBoxUstalonaGrubośćLiniiLiczbowo.Text = "1";
            this.UNRTBoxUstalonaGrubośćLiniiLiczbowo.TextChanged += new System.EventHandler(this.UNRTBoxUstalonaGrubośćLiniiLiczbowo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1011, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ustalona grubość linii\r\n          (liczbowo)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1011, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Wziernik wzorca linii";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 42);
            this.label7.TabIndex = 13;
            this.label7.Text = "Minimalna próba badawcza\r\n(liczba powtórzeń sortowania\r\ntablicy o tych samych roz" +
    "miarach";
            // 
            // UNRTBoxMinimalnaProba
            // 
            this.UNRTBoxMinimalnaProba.Location = new System.Drawing.Point(59, 183);
            this.UNRTBoxMinimalnaProba.Margin = new System.Windows.Forms.Padding(4);
            this.UNRTBoxMinimalnaProba.Name = "UNRTBoxMinimalnaProba";
            this.UNRTBoxMinimalnaProba.Size = new System.Drawing.Size(143, 20);
            this.UNRTBoxMinimalnaProba.TabIndex = 14;
            // 
            // UNRTBoxMaxRozmiarTablic
            // 
            this.UNRTBoxMaxRozmiarTablic.Location = new System.Drawing.Point(59, 262);
            this.UNRTBoxMaxRozmiarTablic.Margin = new System.Windows.Forms.Padding(4);
            this.UNRTBoxMaxRozmiarTablic.Name = "UNRTBoxMaxRozmiarTablic";
            this.UNRTBoxMaxRozmiarTablic.Size = new System.Drawing.Size(143, 20);
            this.UNRTBoxMaxRozmiarTablic.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 211);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "Maksymalny rozmiar\r\n sortowanych tablic";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 312);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 42);
            this.label9.TabIndex = 17;
            this.label9.Text = "Dolna granica przedziału\r\n    wartości elementów \r\n     sortowanych tablic";
            // 
            // UNRTBoxDolnaGranicaPrzedzialu
            // 
            this.UNRTBoxDolnaGranicaPrzedzialu.Location = new System.Drawing.Point(59, 374);
            this.UNRTBoxDolnaGranicaPrzedzialu.Margin = new System.Windows.Forms.Padding(4);
            this.UNRTBoxDolnaGranicaPrzedzialu.Name = "UNRTBoxDolnaGranicaPrzedzialu";
            this.UNRTBoxDolnaGranicaPrzedzialu.Size = new System.Drawing.Size(143, 20);
            this.UNRTBoxDolnaGranicaPrzedzialu.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 416);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 42);
            this.label10.TabIndex = 19;
            this.label10.Text = "Górna granica przedziału\r\n     wartości elementów \r\n     sortowanych tablicy";
            // 
            // UNRTBoxGornaGranicaPrzedzialu
            // 
            this.UNRTBoxGornaGranicaPrzedzialu.Location = new System.Drawing.Point(55, 475);
            this.UNRTBoxGornaGranicaPrzedzialu.Margin = new System.Windows.Forms.Padding(4);
            this.UNRTBoxGornaGranicaPrzedzialu.Name = "UNRTBoxGornaGranicaPrzedzialu";
            this.UNRTBoxGornaGranicaPrzedzialu.Size = new System.Drawing.Size(143, 20);
            this.UNRTBoxGornaGranicaPrzedzialu.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 516);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 14);
            this.label11.TabIndex = 21;
            this.label11.Text = "Wybierz algorytm do analizy";
            // 
            // UNRBtnWynikiFormaTabelaryczna
            // 
            this.UNRBtnWynikiFormaTabelaryczna.Font = new System.Drawing.Font("Georgia", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNRBtnWynikiFormaTabelaryczna.Location = new System.Drawing.Point(966, 277);
            this.UNRBtnWynikiFormaTabelaryczna.Margin = new System.Windows.Forms.Padding(4);
            this.UNRBtnWynikiFormaTabelaryczna.Name = "UNRBtnWynikiFormaTabelaryczna";
            this.UNRBtnWynikiFormaTabelaryczna.Size = new System.Drawing.Size(224, 77);
            this.UNRBtnWynikiFormaTabelaryczna.TabIndex = 24;
            this.UNRBtnWynikiFormaTabelaryczna.Text = "Wyniki analizy algorytmu sortowania w formie tabelarycznej";
            this.UNRBtnWynikiFormaTabelaryczna.UseVisualStyleBackColor = true;
            this.UNRBtnWynikiFormaTabelaryczna.Click += new System.EventHandler(this.UNRBtnWynikiFormaTabelaryczna_Click);
            // 
            // UNRBtnWynikiFormaWykresu
            // 
            this.UNRBtnWynikiFormaWykresu.Font = new System.Drawing.Font("Georgia", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNRBtnWynikiFormaWykresu.Location = new System.Drawing.Point(966, 363);
            this.UNRBtnWynikiFormaWykresu.Name = "UNRBtnWynikiFormaWykresu";
            this.UNRBtnWynikiFormaWykresu.Size = new System.Drawing.Size(224, 77);
            this.UNRBtnWynikiFormaWykresu.TabIndex = 25;
            this.UNRBtnWynikiFormaWykresu.Text = "Wyniki analizy algorytmu sortowania w formie wykresu";
            this.UNRBtnWynikiFormaWykresu.UseVisualStyleBackColor = true;
            this.UNRBtnWynikiFormaWykresu.Click += new System.EventHandler(this.UNRBtnWynikiFormaWykresu_Click);
            // 
            // UNRBtnResetuj
            // 
            this.UNRBtnResetuj.Font = new System.Drawing.Font("Georgia", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNRBtnResetuj.Location = new System.Drawing.Point(966, 446);
            this.UNRBtnResetuj.Name = "UNRBtnResetuj";
            this.UNRBtnResetuj.Size = new System.Drawing.Size(224, 77);
            this.UNRBtnResetuj.TabIndex = 26;
            this.UNRBtnResetuj.Text = "Resetuj \r\n(ustaw stan)";
            this.UNRBtnResetuj.UseVisualStyleBackColor = true;
            this.UNRBtnResetuj.Click += new System.EventHandler(this.UNRBtnResetuj_Click);
            // 
            // UNRBtnDemo
            // 
            this.UNRBtnDemo.Font = new System.Drawing.Font("Georgia", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNRBtnDemo.Location = new System.Drawing.Point(966, 545);
            this.UNRBtnDemo.Name = "UNRBtnDemo";
            this.UNRBtnDemo.Size = new System.Drawing.Size(224, 77);
            this.UNRBtnDemo.TabIndex = 27;
            this.UNRBtnDemo.Text = "DEMO \r\n(działanie algorytmu)";
            this.UNRBtnDemo.UseVisualStyleBackColor = true;
            this.UNRBtnDemo.Click += new System.EventHandler(this.UNRBtnDemo_Click);
            // 
            // UNRBtnWizualizacjaTablicyPrzedSortowaniem
            // 
            this.UNRBtnWizualizacjaTablicyPrzedSortowaniem.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.UNRBtnWizualizacjaTablicyPrzedSortowaniem.Location = new System.Drawing.Point(394, 574);
            this.UNRBtnWizualizacjaTablicyPrzedSortowaniem.Name = "UNRBtnWizualizacjaTablicyPrzedSortowaniem";
            this.UNRBtnWizualizacjaTablicyPrzedSortowaniem.Size = new System.Drawing.Size(179, 65);
            this.UNRBtnWizualizacjaTablicyPrzedSortowaniem.TabIndex = 28;
            this.UNRBtnWizualizacjaTablicyPrzedSortowaniem.Text = "Wizualizacja tablicy przed sortowaniem";
            this.UNRBtnWizualizacjaTablicyPrzedSortowaniem.UseVisualStyleBackColor = true;
            this.UNRBtnWizualizacjaTablicyPrzedSortowaniem.Click += new System.EventHandler(this.UNRBtnWizualizacjaTablicyPrzedSortowaniem_Click);
            // 
            // UNRBtnWizualizacjaTablicyPoSortowaniem
            // 
            this.UNRBtnWizualizacjaTablicyPoSortowaniem.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.UNRBtnWizualizacjaTablicyPoSortowaniem.Location = new System.Drawing.Point(596, 574);
            this.UNRBtnWizualizacjaTablicyPoSortowaniem.Name = "UNRBtnWizualizacjaTablicyPoSortowaniem";
            this.UNRBtnWizualizacjaTablicyPoSortowaniem.Size = new System.Drawing.Size(179, 65);
            this.UNRBtnWizualizacjaTablicyPoSortowaniem.TabIndex = 29;
            this.UNRBtnWizualizacjaTablicyPoSortowaniem.Text = "Wizualizacja tablicy po sortowaniu";
            this.UNRBtnWizualizacjaTablicyPoSortowaniem.UseVisualStyleBackColor = true;
            this.UNRBtnWizualizacjaTablicyPoSortowaniem.Click += new System.EventHandler(this.UNRBtnWizualizacjaTablicyPoSortowaniem_Click);
            // 
            // UNRGrzebieniowe
            // 
            this.UNRGrzebieniowe.AutoSize = true;
            this.UNRGrzebieniowe.Location = new System.Drawing.Point(55, 545);
            this.UNRGrzebieniowe.Name = "UNRGrzebieniowe";
            this.UNRGrzebieniowe.Size = new System.Drawing.Size(170, 18);
            this.UNRGrzebieniowe.TabIndex = 30;
            this.UNRGrzebieniowe.TabStop = true;
            this.UNRGrzebieniowe.Text = "Sortowanie Grzebieniowe";
            this.UNRGrzebieniowe.UseVisualStyleBackColor = true;
            // 
            // UNRShell
            // 
            this.UNRShell.AutoSize = true;
            this.UNRShell.Location = new System.Drawing.Point(55, 570);
            this.UNRShell.Name = "UNRShell";
            this.UNRShell.Size = new System.Drawing.Size(144, 18);
            this.UNRShell.TabIndex = 31;
            this.UNRShell.TabStop = true;
            this.UNRShell.Text = "Sortowanie Shellsort";
            this.UNRShell.UseVisualStyleBackColor = true;
            // 
            // UNRDgvPrzedSortowaniem
            // 
            this.UNRDgvPrzedSortowaniem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UNRDgvPrzedSortowaniem.Location = new System.Drawing.Point(277, 118);
            this.UNRDgvPrzedSortowaniem.Name = "UNRDgvPrzedSortowaniem";
            this.UNRDgvPrzedSortowaniem.Size = new System.Drawing.Size(682, 405);
            this.UNRDgvPrzedSortowaniem.TabIndex = 32;
            // 
            // UNRDgvPoSortowaniu
            // 
            this.UNRDgvPoSortowaniu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UNRDgvPoSortowaniu.Location = new System.Drawing.Point(277, 118);
            this.UNRDgvPoSortowaniu.Name = "UNRDgvPoSortowaniu";
            this.UNRDgvPoSortowaniu.Size = new System.Drawing.Size(682, 405);
            this.UNRDgvPoSortowaniu.TabIndex = 33;
            // 
            // UNRChart
            // 
            chartArea1.Name = "ChartArea1";
            this.UNRChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.UNRChart.Legends.Add(legend1);
            this.UNRChart.Location = new System.Drawing.Point(277, 118);
            this.UNRChart.Name = "UNRChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.UNRChart.Series.Add(series1);
            this.UNRChart.Size = new System.Drawing.Size(682, 405);
            this.UNRChart.TabIndex = 34;
            this.UNRChart.Text = "chart1";
            // 
            // UNRPanPodgladWykresu
            // 
            this.UNRPanPodgladWykresu.Location = new System.Drawing.Point(1030, 230);
            this.UNRPanPodgladWykresu.Name = "UNRPanPodgladWykresu";
            this.UNRPanPodgladWykresu.Size = new System.Drawing.Size(100, 40);
            this.UNRPanPodgladWykresu.TabIndex = 35;
            // 
            // UNREP_Sprawdz
            // 
            this.UNREP_Sprawdz.ContainerControl = this;
            // 
            // UNRGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1278, 672);
            this.Controls.Add(this.UNRPanPodgladWykresu);
            this.Controls.Add(this.UNRChart);
            this.Controls.Add(this.UNRDgvPoSortowaniu);
            this.Controls.Add(this.UNRDgvPrzedSortowaniem);
            this.Controls.Add(this.UNRShell);
            this.Controls.Add(this.UNRGrzebieniowe);
            this.Controls.Add(this.UNRBtnWizualizacjaTablicyPoSortowaniem);
            this.Controls.Add(this.UNRBtnWizualizacjaTablicyPrzedSortowaniem);
            this.Controls.Add(this.UNRBtnDemo);
            this.Controls.Add(this.UNRBtnResetuj);
            this.Controls.Add(this.UNRBtnWynikiFormaWykresu);
            this.Controls.Add(this.UNRBtnWynikiFormaTabelaryczna);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.UNRTBoxGornaGranicaPrzedzialu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.UNRTBoxDolnaGranicaPrzedzialu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UNRTBoxMaxRozmiarTablic);
            this.Controls.Add(this.UNRTBoxMinimalnaProba);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UNRTBoxUstalonaGrubośćLiniiLiczbowo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UNRTBarZmieńGrubośćLinii);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UNRComboBoxUstalStylLiniiWykresu);
            this.Controls.Add(this.UNRTBoxWziernikKoloruTla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UNRTBoxWziernikKoloruLinii);
            this.Controls.Add(this.UNRBtnWybierzKolorTła);
            this.Controls.Add(this.UNRBtnWybierzKolorLinii);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UNRGlowne";
            this.Text = "Analizator algorytmów sortowania";
            ((System.ComponentModel.ISupportInitialize)(this.UNRTBarZmieńGrubośćLinii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNRDgvPrzedSortowaniem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNRDgvPoSortowaniu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNRChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNREP_Sprawdz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UNRBtnWybierzKolorLinii;
        private System.Windows.Forms.Button UNRBtnWybierzKolorTła;
        private System.Windows.Forms.TextBox UNRTBoxWziernikKoloruLinii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UNRTBoxWziernikKoloruTla;
        private System.Windows.Forms.ComboBox UNRComboBoxUstalStylLiniiWykresu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar UNRTBarZmieńGrubośćLinii;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UNRTBoxUstalonaGrubośćLiniiLiczbowo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UNRTBoxMinimalnaProba;
        private System.Windows.Forms.TextBox UNRTBoxMaxRozmiarTablic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UNRTBoxDolnaGranicaPrzedzialu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox UNRTBoxGornaGranicaPrzedzialu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button UNRBtnWynikiFormaTabelaryczna;
        private System.Windows.Forms.Button UNRBtnWynikiFormaWykresu;
        private System.Windows.Forms.Button UNRBtnResetuj;
        private System.Windows.Forms.Button UNRBtnDemo;
        private System.Windows.Forms.Button UNRBtnWizualizacjaTablicyPrzedSortowaniem;
        private System.Windows.Forms.Button UNRBtnWizualizacjaTablicyPoSortowaniem;
        private System.Windows.Forms.RadioButton UNRGrzebieniowe;
        private System.Windows.Forms.RadioButton UNRShell;
        private System.Windows.Forms.DataGridView UNRDgvPrzedSortowaniem;
        private System.Windows.Forms.DataGridView UNRDgvPoSortowaniu;
        private System.Windows.Forms.DataVisualization.Charting.Chart UNRChart;
        private System.Windows.Forms.Panel UNRPanPodgladWykresu;
        private System.Windows.Forms.ErrorProvider UNREP_Sprawdz;


    }
}

