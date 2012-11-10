using System;

namespace RouletteLogic.Formatters
{
    public class ResultTabFormatter : ResultFormatterBase
    {
        private const string Delimiter = "\t";

        public override string GetHeader()
        {
            return string.Join(Delimiter, HeaderTextList);
        }

        public override string GetDetail(ResultDataItem item)
        {
            return string.Join(Delimiter, 
                string.Format("{0:c}",item.Bankroll), 
                item.Bet.Color, 
                string.Format("{0:c}",item.Bet.Amount), 
                string.Format("{0:c}",item.Result.BetAmount), 
                item.Result.IsWin);
        }
    }
}