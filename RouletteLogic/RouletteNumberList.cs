using System.Collections.Generic;

namespace RouletteLogic
{
    internal class RouletteNumberList : List<RouletteNumber>
    {
        public RouletteNumberList()
        {
            InitializeNumbers();
        }

        private void InitializeNumbers()
        {
            bool useRed = true;

            for (int i = 0; i < 38; i++)
            {
                switch (i)
                {
                    case 37:
                        Add(new RouletteNumber(ColorBet.Green, "0"));
                        break;
                    case 38:
                        Add(new RouletteNumber(ColorBet.Green, "00"));
                        break;
                    default:
                        Add(useRed
                                ? new RouletteNumber(ColorBet.Red, (i + 1).ToString())
                                : new RouletteNumber(ColorBet.Black, (i + 1).ToString()));
                        break;
                }

                useRed = !useRed;
            }
        }
    }
}