using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170808_VasyaClerk
{
    [TestClass]
    public class VasyaClerkTests
    {
        [TestMethod]
        public void input_25_should_return_Yes()
        {
            PeopleInLineTicketShouldBe("YES", new[] { 25 });
        }

        [TestMethod]
        public void input_50_should_return_No()
        {
            PeopleInLineTicketShouldBe("NO", new[] { 50 });
        }

        [TestMethod]
        public void input_100_should_return_No()
        {
            PeopleInLineTicketShouldBe("NO", new []{ 100 });
        }

        private static void PeopleInLineTicketShouldBe(string expected, int[] peopleInLine)
        {
            Assert.AreEqual(expected, new Line().Tickets(peopleInLine));
        }
    }

    public class Line
    {
        public string Tickets(int[] peopleInLine)
        {
            if (peopleInLine[0] == 50 || peopleInLine[0] == 100)
            {
                return "NO";
            }
            return "YES";
        }
    }
}
