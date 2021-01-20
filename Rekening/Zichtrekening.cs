namespace Rekening
{
    public class Zichtrekening : Rekening
    {
        public Zichtrekening(string rekeningNr, double saldo)
            : base(rekeningNr, saldo)
        {
            Minimum = -100;
        }
    }
}