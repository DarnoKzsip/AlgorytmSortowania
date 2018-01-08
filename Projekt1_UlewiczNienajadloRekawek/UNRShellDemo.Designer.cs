namespace Projekt1_UlewiczNienajadloRekawek
{
    partial class UNRShellDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UNRShellDemo));
            this.UNRPBShell = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UNRPBShell)).BeginInit();
            this.SuspendLayout();
            // 
            // UNRPBShell
            // 
            this.UNRPBShell.Image = ((System.Drawing.Image)(resources.GetObject("UNRPBShell.Image")));
            this.UNRPBShell.Location = new System.Drawing.Point(2, 2);
            this.UNRPBShell.Name = "UNRPBShell";
            this.UNRPBShell.Size = new System.Drawing.Size(288, 348);
            this.UNRPBShell.TabIndex = 0;
            this.UNRPBShell.TabStop = false;
            // 
            // UNRShellDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 362);
            this.Controls.Add(this.UNRPBShell);
            this.Name = "UNRShellDemo";
            this.Text = "UNRShellDemo";
            ((System.ComponentModel.ISupportInitialize)(this.UNRPBShell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox UNRPBShell;
    }
}