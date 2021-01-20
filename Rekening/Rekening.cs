using System.Windows.Forms;

namespace Rekening
{
    public class Rekening
    {
        private double _minimum;

        public double Minimum
        {
            get { return _minimum; }
            set { _minimum = value; }
        }

        private string _rekeningnr;

        public string RekeningNr
        {
            get { return _rekeningnr; }
            set { _rekeningnr = value; }
        }

        private double _saldo;

        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < Minimum)
                {
                    MessageBox.Show($"Invalid operation", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _saldo = value;
                }
            }
        }

        public Rekening(string rekeningNr, double saldo)
        {
            RekeningNr = rekeningNr;
            Saldo = saldo;
            Minimum = 0;
        }

        public void Storten(double bedrag)
        {
            Saldo += bedrag;
        }

        public void Afhalen(double bedrag)
        {
            Saldo -= bedrag;
        }

        public override string ToString()
        {
            return $"Rekeningnummer {RekeningNr} met saldo {Saldo}";
        }
    }
}