namespace Anagrafica_Classi_Studenti
{
    partial class Classi
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
            this.buttonChiudi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChiudi
            // 
            this.buttonChiudi.Location = new System.Drawing.Point(587, 383);
            this.buttonChiudi.Name = "buttonChiudi";
            this.buttonChiudi.Size = new System.Drawing.Size(75, 23);
            this.buttonChiudi.TabIndex = 3;
            this.buttonChiudi.Text = "Chiudi";
            this.buttonChiudi.UseVisualStyleBackColor = true;
            this.buttonChiudi.Click += new System.EventHandler(this.button1_Click);
            // 
            // Classi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 418);
            this.Controls.Add(this.buttonChiudi);
            this.Name = "Classi";
            this.Text = "Classi";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonChiudi;
    }
}