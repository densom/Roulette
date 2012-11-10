using System;

namespace Roulette.Formatters
{
    internal class ResultTabFormatter : ResultFormatterBase
    {
        private string delimiter = "\t";

        public override string GetHeader()
        {
            return string.Join(delimiter, HeaderTextList);
        }

        public override string GetDetail(ResultDataItem item)
        {
            return string.Join(delimiter, 
                string.Format("{0:c}",item.Bankroll), 
                item.Bet.Color, 
                string.Format("{0:c}",item.Bet.Amount), 
                string.Format("{0:c}",item.Result.BetAmount), 
                item.Result.IsWin);
        }
    }
}