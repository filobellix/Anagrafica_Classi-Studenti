namespace Anagrafica_Classi_Studenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void classiStudentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classi_Studenti studenti = new Classi_Studenti();
            studenti.ShowDialog();
        }

        private void anagraficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anagrafica anagrafica = new Anagrafica();
            anagrafica.ShowDialog();
        }

        private void classiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classi classi = new Classi();
            classi.ShowDialog();
        }
    }
}