namespace Projekt1_UlewiczNienajadloRekawek
{
    partial class UNRComboSort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UNRComboSort));
            this.UNRPBCombo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UNRPBCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // UNRPBCombo
            // 
            this.UNRPBCombo.Image = ((System.Drawing.Image)(resources.GetObject("UNRPBCombo.Image")));
            this.UNRPBCombo.Location = new System.Drawing.Point(12, 12);
            this.UNRPBCombo.Name = "UNRPBCombo";
            this.UNRPBCombo.Size = new System.Drawing.Size(272, 260);
            this.UNRPBCombo.TabIndex = 0;
            this.UNRPBCombo.TabStop = false;
            // 
            // UNRComboSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 285);
            this.Controls.Add(this.UNRPBCombo);
            this.Name = "UNRComboSort";
            this.Text = "UNRComboSort";
            ((System.ComponentModel.ISupportInitialize)(this.UNRPBCombo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox UNRPBCombo;
    }
}