using System;
using System.Linq;

namespace RouletteLogic
{
    public class BetTypeValue
    {
        public string StringValue { get; private set; }
        public RouletteColors RouletteColor { get; private set; }
        public int NumberBetValue { get; private set; }

        public BetTypeValue(string stringValue):this(stringValue, 0)
        {
        }

        public BetTypeValue(string stringValue, int numberBetValue)
        {
            StringValue = stringValue;
            NumberBetValue = numberBetValue;
            SetRouletteColor(stringValue, numberBetValue);
        }

        private void SetRouletteColor(string stringValue, int numberBetValue)
        {
            switch (stringValue)
            {
                case "Red":
                    RouletteColor = RouletteColors.Red;
                    break;
                case "Black":
                    RouletteColor = RouletteColors.Black;
                    break;
                case "Green":
                    RouletteColor = RouletteColors.Green;
                    break;
                case "Zero":
                    RouletteColor = RouletteColors.Green;
                    break;
                case "DoubleZero":
                    RouletteColor = RouletteColors.Green;
                    break;
                case "Number":
                    var numbers = new RouletteNumberList();
                    RouletteColor = numbers.Where(n => n.Value == numberBetValue.ToString()).First().RouletteColor;
                    break;
                default:
                    break;

            }
        }
    }
}