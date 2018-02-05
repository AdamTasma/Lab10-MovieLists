using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    [TestFixture]
    class MovieTest
    {
        [Test]
        public void DisplayMenuWorks()
        {
            int expected = 1;
            int actual = Program.displayMenu();
            Assert.AreEqual(expected, actual, "It doesn't display the menu");
        }

    }
}
