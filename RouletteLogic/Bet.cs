using System;
using System.Diagnostics;

namespace RouletteLogic
{
    public class Bet
    {
       
        public int Amount { get; set; }
        public BetTypeValue BetType { get; protected set; }

        public Bet(BetTypeValue betType, int amount)
        {
            BetType = betType;
            Amount = amount;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1:c}", BetType, Amount);
        }
    }
}