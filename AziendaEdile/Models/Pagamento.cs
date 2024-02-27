namespace AziendaEdile.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public DateOnly PeriodoInizio { get; set; }
        public DateOnly PeriodoFine { get; set; }
        public decimal Importo { get; set; }
    }
}
