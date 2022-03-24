using Lottery.Domain.Enums;

namespace Lottery.Domain.Entities
{
    public class VolantLottery
    {
        public VolantLottery(LotteryTypeEnum lotteryType, int volantIndex)
        {
            LotteryType = lotteryType;            
            TotalDozens = GetLotteryMaximumDozens(lotteryType);
            VolantCode = GenerateVolantCode(lotteryType, volantIndex);
            DozensList = CreateDozensList(TotalDozens, VolantCode);
        }

        public string VolantCode { get; private set; }
        public LotteryTypeEnum LotteryType { get; set; }                
        public List<DozenVolant> DozensList { get; set; }
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

        private List<DozenVolant> CreateDozensList(int totalDozens, string volantId)
        {
            var list = new List<DozenVolant>();

            for (int i = 1; i <= totalDozens; i++)
            {
                var dozen = i.ToString();
                if (dozen.Length == 1) { dozen = $"0{dozen}"; }

                list.Add(new DozenVolant(dozen, volantId));
            }

            return list;
        }

        private string GenerateVolantCode(LotteryTypeEnum lotteryTypeEnum, int volantIndex) => $"{lotteryTypeEnum}_{volantIndex}_";        

    }
}
