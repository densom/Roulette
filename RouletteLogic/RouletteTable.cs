using System;
using System.Collections.Generic;

namespace RouletteLogic
{
    public class RouletteTable
    {
        private readonly Random _random = new Random();
        private readonly List<Bet> _bets = new List<Bet>();
        private int _tableLimit;
        public RouletteTable(int tableLimit)
        {
            TableLimit = tableLimit;
        }
        public int TableLimit
        {
            get { return _tableLimit; } 
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Table limit must be greater than zero");
                }

                _tableLimit = value;
            }
        }
        public void PlaceBet(Bet bet)
        {
            _bets.Add(bet);
        }
        private void ClearBets()
        {
            _bets.Clear();
        }
        private void ValidateBets()
        {
            foreach (var bet in _bets)
            {

                if (bet.Amount > TableLimit)
                {
                    throw new ArgumentException("Bet amount exceeds table limit");
                }

                if (bet.BetType == BetType.Green)
                {
                    throw new ArgumentException("Cannot bet on green");
                }

                if (!(bet.Amount > 0))
                {
                    throw new ArgumentException("Bet must bet greater than 0");
                }
            }
        }
        public List<Result> PlayGames()
        {
            List<Result> results = new List<Result>(_bets.Count);

            ValidateBets();

            RouletteNumber numberRolled = RollTheBall();

            foreach (var bet in _bets)
            {
                
                var result = new Result();
                result.IsWin = numberRolled.RouletteColor == bet.BetType.RouletteColor;
                result.NetAmount = result.IsWin ? bet.Amount * 2 : 0;
                result.BetAmount = bet.Amount;

                results.Add(result);
            }

            ClearBets();

            return results;

        }
        public Result BetSingle(Bet bet)
        {
            PlaceBet(bet);
            return PlayGames()[0];
        }
        public Result BetSingle(BetTypeValue betTypeValue, int betAmount)
        {
            return BetSingle(new Bet(betTypeValue, betAmount));
        }
        private RouletteNumber RollTheBall()
        {
            var rouletteNumberList = new RouletteNumberList();
            int index = _random.Next(0, rouletteNumberList.Count);
            return rouletteNumberList[index];
        }
    }
}