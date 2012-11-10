namespace Roulette
{
    internal class Result
    {
        public int NetAmount { get; set; }
        public bool IsWin { get; set; }
        public int BetAmount { get; set; }

        public override string ToString()
        {
            return string.Format("{0:c}\t{1}", NetAmount, IsWin);
        }
    }
}