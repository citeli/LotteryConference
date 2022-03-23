namespace Lottery.Domain.Entities
{
    public class Bets
    {
        public Bets()
        {
            Volants = new List<Volant>();
        }
        public List<Volant> Volants { get; set; }
    }
}
