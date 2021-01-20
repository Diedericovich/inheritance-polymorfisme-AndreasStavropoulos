using System;
using System.Windows.Forms;

namespace Rekening
{
    public partial class Form1 : Form
    {
        private Rekening rekening = new Rekening("BE123", 25000);
        private Spaarrekening spaarrekening = new Spaarrekening("BES123", 100);
        private Zichtrekening zichtrekening = new Zichtrekening("BEZ123", 0);

        public Form1()
        {
            InitializeComponent();
            lblRekening.Text = rekening.ToString();
            lblSpaar.Text = spaarrekening.ToString();
            lblZicht.Text = zichtrekening.ToString();
        }

        public void btnRekeningPlus_Click(object sender, EventArgs e)
        {
            AddAmount(txtRekening.Text, lblRekening, rekening);
        }

        private void btnRekeningMinus_Click(object sender, EventArgs e)
        {
            DecreaseAmount(txtRekening.Text, lblRekening, rekening);
        }

        private void btnSpaarPlus_Click(object sender, EventArgs e)
        {
            AddAmount(txtSpaarRekening.Text, lblSpaar, spaarrekening);
        }

        private void btnSpaarMinus_Click(object sender, EventArgs e)
        {
            DecreaseAmount(txtSpaarRekening.Text, lblSpaar, spaarrekening);
        }

        private void btnZichtPlus_Click(object sender, EventArgs e)
        {
            AddAmount(txtZichtrekening.Text, lblZicht, zichtrekening);
        }

        private void btnZichtMinus_Click(object sender, EventArgs e)
        {
            DecreaseAmount(txtZichtrekening.Text, lblZicht, zichtrekening);
        }

        public void AddAmount(string textbox, Label label, Rekening rekening)
        {
            double amount = Convert.ToDouble(textbox);
            rekening.Storten(amount);
            label.Text = rekening.ToString();
        }

        public void DecreaseAmount(string textbox, Label label, Rekening rekening)
        {
            double amount = Convert.ToDouble(textbox);
            rekening.Afhalen(amount);
            label.Text = rekening.ToString();
        }

        private void btnRente_Click(object sender, EventArgs e)
        {
            spaarrekening.SchrijfRenteBij();
            lblSpaar.Text = spaarrekening.ToString();
        }
    }
}