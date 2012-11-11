using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace RouletteLogic.Tests
{
    [TestFixture]
    public class RouletteTableTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Table_EnsureLimitGreaterThanZero()
        {
            var table = new RouletteTable(-1);

        }

        [Test]
        public void notsureyet()
        {
            var table = new RouletteTable(100);
        }


    }
}
