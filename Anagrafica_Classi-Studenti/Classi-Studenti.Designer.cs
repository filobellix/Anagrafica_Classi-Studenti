namespace Anagrafica_Classi_Studenti
{
    partial class Classi_Studenti
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
            this.comboBoxStudenti = new System.Windows.Forms.ComboBox();
            this.comboBoxClassi = new System.Windows.Forms.ComboBox();
            this.buttonChiudi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxStudenti
            // 
            this.comboBoxStudenti.FormattingEnabled = true;
            this.comboBoxStudenti.Location = new System.Drawing.Point(164, 12);
            this.comboBoxStudenti.Name = "comboBoxStudenti";
            this.comboBoxStudenti.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStudenti.TabIndex = 0;
            this.comboBoxStudenti.Text = "Studenti";
            // 
            // comboBoxClassi
            // 
            this.comboBoxClassi.FormattingEnabled = true;
            this.comboBoxClassi.Location = new System.Drawing.Point(12, 12);
            this.comboBoxClassi.Name = "comboBoxClassi";
            this.comboBoxClassi.Size = new System.Drawing.Size(121, 23);
            this.comboBoxClassi.TabIndex = 1;
            this.comboBoxClassi.Text = "Classi";
            // 
            // buttonChiudi
            // 
            this.buttonChiudi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChiudi.Location = new System.Drawing.Point(567, 338);
            this.buttonChiudi.Name = "buttonChiudi";
            this.buttonChiudi.Size = new System.Drawing.Size(75, 23);
            this.buttonChiudi.TabIndex = 2;
            this.buttonChiudi.Text = "Chiudi";
            this.buttonChiudi.UseVisualStyleBackColor = true;
            this.buttonChiudi.Click += new System.EventHandler(this.button1_Click);
            // 
            // Classi_Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 373);
            this.Controls.Add(this.buttonChiudi);
            this.Controls.Add(this.comboBoxClassi);
            this.Controls.Add(this.comboBoxStudenti);
            this.Name = "Classi_Studenti";
            this.Text = "Classi_Studenti";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBoxStudenti;
        private ComboBox comboBoxClassi;
        private Button buttonChiudi;
    }
}