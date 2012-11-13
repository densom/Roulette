using NUnit.Framework;

namespace RouletteLogic.Tests
{
    [TestFixture]
    public class BetTests
    {
        [Test]
        public void VerifyRouletteColor()
        {
            var bet = new Bet(BetType.Red, 100);
            Assert.AreEqual(RouletteColors.Red, bet.BetType.RouletteColor);
        }

        [Test]
        public void VerifyAmount()
        {
            var bet = new Bet(BetType.Black, 123);
            Assert.AreEqual(123, bet.Amount);
        }

        [Test]
        public void Number17BetValue()
        {
            var bet = new Bet(BetType.Number17, 100);
            Assert.AreEqual(17, bet.BetType.NumberBetValue);
        }

        [Test]
        public void Number17BetColor()
        {
            var bet = new Bet(BetType.Number17, 100);
            Assert.AreEqual(RouletteColors.Black, bet.BetType.RouletteColor);
        }

        [Test]
        public void Number18BetColor()
        {
            var bet = new Bet(BetType.Number18, 100);
            Assert.AreEqual(RouletteColors.Red, bet.BetType.RouletteColor);
        }

        [Test]
        public void Number0BetColor()
        {
            var bet = new Bet(BetType.Zero, 100);
            Assert.AreEqual(RouletteColors.Green, bet.BetType.RouletteColor);
            Assert.AreEqual(0, bet.BetType.NumberBetValue);
        }

        [Test]
        public void Number00BetColor()
        {
            var bet = new Bet(BetType.DoubleZero, 100);
            Assert.AreEqual(RouletteColors.Green, bet.BetType.RouletteColor);
            Assert.AreEqual(0, bet.BetType.NumberBetValue);
        }
    }
}