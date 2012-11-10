using System.Collections.Generic;

namespace Roulette.Formatters
{
    abstract internal class ResultFormatterBase : IResultFormatter
    {
        protected List<string> HeaderTextList = new List<string> {"Bankroll","Color","BetAmount","WinAmount","IsWin"};

        public abstract string GetHeader();
        public abstract string GetDetail(ResultDataItem item);

    }
}