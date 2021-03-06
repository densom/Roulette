﻿using System.Collections.Generic;

namespace RouletteLogic
{
    public enum RouletteColors
    {
        Green,
        Red,
        Black
    }

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
                        Add(new RouletteNumber(RouletteColors.Green, "0"));
                        break;
                    case 38:
                        Add(new RouletteNumber(RouletteColors.Green, "00"));
                        break;
                    default:
                        Add(useRed
                                ? new RouletteNumber(RouletteColors.Black, (i + 1).ToString())
                                : new RouletteNumber(RouletteColors.Red, (i + 1).ToString()));
                        break;
                }

                useRed = !useRed;
            }
        }
    }
}