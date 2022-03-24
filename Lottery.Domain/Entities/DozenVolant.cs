namespace Lottery.Domain.Entities
{
    public class DozenVolant
    {
        public string Dozen { get; private set; }
        public string VolantId { get; private set; }

        public DozenVolant(string dozen, string volantId)
        {
            Dozen = dozen;
            VolantId = volantId;
        }


    }
}
