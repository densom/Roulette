using System;

namespace RouletteLogic
{
    public class RouletteTable
    {
        private readonly Random _random = new Random();

        public RouletteTable(int tableLimit)
        {
            TableLimit = tableLimit;
        }

        public int TableLimit { get; set; }

        public Result Bet(Bet bet)
        {
            return Bet(bet.Color, bet.Amount);
        }

        public Result Bet(ColorBet colorBet, int betAmount)
        {
            if (betAmount > TableLimit)
            {
                throw new ArgumentException("Bet amount exceeds table limit");
            }

            if (colorBet == ColorBet.Green)
            {
                throw new ArgumentException("Cannot bet on green");
            }

            if (!(betAmount > 0))
            {
                throw new ArgumentException("Bet must bet greater than 0");
            }

            RouletteNumber numberRolled = RollTheBall();

            var result = new Result();
            result.IsWin = numberRolled.Color == colorBet;
            result.NetAmount = result.IsWin ? betAmount*2 : 0;
            result.BetAmount = betAmount;

            return result;
        }

        private RouletteNumber RollTheBall()
        {
            var rouletteNumberList = new RouletteNumberList();
            int index = _random.Next(0, rouletteNumberList.Count);
            return rouletteNumberList[index];
        }
    }
}