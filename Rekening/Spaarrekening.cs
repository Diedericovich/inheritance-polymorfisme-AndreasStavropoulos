namespace Rekening
{
    public class Spaarrekening : Rekening
    {
        private double _percentage;

        public double Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }

        public Spaarrekening(string rekeningNr, double saldo)
            : base(rekeningNr, saldo)
        {
            Percentage = 0.05;
        }

        public void SchrijfRenteBij()
        {
            Saldo += Saldo * Percentage;
        }

        public override string ToString()
        {
            string percentage = $"(percentage {Percentage})";
            return base.ToString() + " " + percentage;
        }
    }
}