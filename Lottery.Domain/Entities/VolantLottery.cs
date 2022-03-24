using Lottery.Domain.Enums;

namespace Lottery.Domain.Entities
{
    public class VolantLottery
    {
        public VolantLottery(LotteryTypeEnum lotteryType)
        {
            LotteryType = lotteryType;            
            TotalDozens = GetLotteryMaximumDozens(lotteryType);
            VolantCode = Guid.NewGuid().ToString();
            Dozens = CreateDozensList(TotalDozens);
        }

        public string VolantCode { get; private set; }
        public LotteryTypeEnum LotteryType { get; set; }        
        public List<string> Dozens { get; private set; }
        public int TotalDozens { get; private set; }

        private int GetLotteryMaximumDozens(LotteryTypeEnum lotteryTypeEnum)
        {
            int totalDozens = 0;
            if (lotteryTypeEnum == LotteryTypeEnum.Lotofacil)
            {
                totalDozens = 25;
            }
            if (lotteryTypeEnum == LotteryTypeEnum.Lotomania)
            {
                totalDozens = 50;
            }
            if (lotteryTypeEnum == LotteryTypeEnum.Megasena)
            {
                totalDozens = 60;
            }
            
            return totalDozens;
        }

        private List<string> CreateDozensList(int totalDozens)
        {
            var list = new List<string>();

            for (int i = 1; i <= totalDozens; i++)
            {
                var dozen = i.ToString();
                if (dozen.Length == 1) { dozen = $"0{dozen}"; }
                list.Add(dozen);
            }

            return list;
        }
    }
}
