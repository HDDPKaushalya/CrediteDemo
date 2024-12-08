namespace CrediteCardAPI.Models
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string CardType { get; set; }
        public DateTime CardExpTime { get; set; }
        public int SerccardNumber { get; set; }
    }
}
