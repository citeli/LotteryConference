namespace Lottery.Domain.Entities
{
    public class Bets
    {
        public Bets()
        {
            Volants = new List<VolantLottery>();
        }
        public List<VolantLottery> Volants { get; set; }
    }
}
