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

        private static void PeopleInLineTicketShouldBe(string expected, int[] peopleInLine)
        {
            Assert.AreEqual(expected, new Line().Tickets(peopleInLine));
        }
    }

    public class Line
    {
        public string Tickets(int[] peopleInLine)
        {
            return "YES";
        }
    }
}
