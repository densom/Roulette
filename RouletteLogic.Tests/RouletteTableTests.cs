using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RouletteLogic.BettingStrategies;

namespace RouletteLogic.Tests
{
    [TestFixture]
    public class RouletteTableTests
    {
        private RouletteTable _table100;

        [SetUp]
        public virtual void SetUp()
        {
            _table100 = new RouletteTable(100);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Table_EnsureLimitGreaterThanZero()
        {
            var table = new RouletteTable(-1);
            Assert.Fail();
        }

        [Test]
        public void NetAmountAccurate()
        {
            var result = _table100.BetSingle(new Bet(BetType.Black, 10));

            if (result.IsWin)
            {
                Assert.AreEqual(20, result.NetAmount);
            }
            else
            {
                Assert.AreEqual(0, result.NetAmount);
            }

        }

        [Test]
        public void BetASpecificNumber()
        {
//            var bet = new 
        }

        

        [Test]
        public void ValidateMartingaleStrategyMakesYouGoBroke()
        {
            int bankRoll = 100;
            Result lastResult = null;
            
            var martingaleStrategy = new MartingaleStrategy();

            for (int i = 0; i < 1000; i++)
            {
                var bet = martingaleStrategy.DetermineBet(bankRoll, 10, _table100.TableLimit, lastResult);
                var result = _table100.BetSingle(bet);
                bankRoll = Helper.TallyResult(bankRoll, bet, result);

                if (bankRoll <= 0)
                {
                    break;
                }
            }

            Assert.LessOrEqual(bankRoll, 0);
        }
    }
}
