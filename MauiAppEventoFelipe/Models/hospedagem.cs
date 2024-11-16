namespace MauiAppEventoFelipe.Models
{
    public class Hospedagem
    {
        public int QntAdultos { get; set; }
        public DateTime DataCheckin { get; set; }
        public DateTime DataCheckout { get; set; }
        public String Nome { get; set; }
        public String Local { get; set; }
        public int dias { get; set; }



        public int Estadia
        {
            get => DataCheckout.Subtract(DataCheckin).Days;
        }

        public double ValorTotal
        {
            get
            {
                double valor_adultos = QntAdultos * 100;

                double total = (valor_adultos) * Estadia;

                double dias = DataCheckout.Day - DataCheckin.Day;

                return total;
            }

        }

    }
}
