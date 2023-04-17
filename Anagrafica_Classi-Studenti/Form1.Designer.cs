namespace Anagrafica_Classi_Studenti
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.classiStudentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anagraficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classiStudentiToolStripMenuItem,
            this.anagraficaToolStripMenuItem,
            this.classiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // classiStudentiToolStripMenuItem
            // 
            this.classiStudentiToolStripMenuItem.Name = "classiStudentiToolStripMenuItem";
            this.classiStudentiToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.classiStudentiToolStripMenuItem.Text = "Classi-Studenti";
            this.classiStudentiToolStripMenuItem.Click += new System.EventHandler(this.classiStudentiToolStripMenuItem_Click);
            // 
            // anagraficaToolStripMenuItem
            // 
            this.anagraficaToolStripMenuItem.Name = "anagraficaToolStripMenuItem";
            this.anagraficaToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.anagraficaToolStripMenuItem.Text = "Anagrafica ";
            this.anagraficaToolStripMenuItem.Click += new System.EventHandler(this.anagraficaToolStripMenuItem_Click);
            // 
            // classiToolStripMenuItem
            // 
            this.classiToolStripMenuItem.Name = "classiToolStripMenuItem";
            this.classiToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.classiToolStripMenuItem.Text = "Classi";
            this.classiToolStripMenuItem.Click += new System.EventHandler(this.classiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem classiStudentiToolStripMenuItem;
        private ToolStripMenuItem anagraficaToolStripMenuItem;
        private ToolStripMenuItem classiToolStripMenuItem;
    }
}