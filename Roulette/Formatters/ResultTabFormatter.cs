using System;

namespace Roulette.Formatters
{
    internal class ResultTabFormatter : ResultFormatterBase
    {
        public override string GetHeader()
        {
            return string.Join("\t", HeaderTextList);
        }

        public override string GetDetail(ResultDataItem item)
        {
            //todo: remove the tab formatting from Bet/Result
            return string.Join("\t", item.Bankroll, item.Bet, item.Result);
        }
    }
}