using Lottery.Domain.Enums;

namespace Lottery.Domain.Entities
{
    public class Volant
    {
        public Volant(LotteryTypeEnum lotteryType, string? volantCode, List<int> dozens)
        {
            LotteryType = lotteryType;
            VolantCode = volantCode;
            Dozens = dozens;
        }
        public LotteryTypeEnum LotteryType { get; set; }
        public string? VolantCode { get; set; }
        public List<int> Dozens { get; set; }

    }
}
