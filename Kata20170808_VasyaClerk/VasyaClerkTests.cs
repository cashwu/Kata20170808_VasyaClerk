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

        [TestMethod]
        public void input_25_100_should_return_No()
        {
            PeopleInLineTicketShouldBe("NO", new[] { 25, 100 });
        }

        [TestMethod]
        public void input_25_50_should_return_No()
        {
            PeopleInLineTicketShouldBe("YES", new[] { 25, 50 });
        }

        [TestMethod]
        public void input_25_50_50_should_return_No()
        {
            PeopleInLineTicketShouldBe("NO", new[] { 25, 50, 50 });
        }

        [TestMethod]
        public void input_25_50_100_should_return_No()
        {
            PeopleInLineTicketShouldBe("NO", new[] { 25, 50, 100 });
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
            var receivced = 0;
            foreach (int ticket in peopleInLine)
            {
                if (ticket == 25)
                {
                    receivced += 25;
                    continue;
                }

                if (ticket - 25 > receivced)
                {
                    return "NO";
                }

                receivced -= 25;
            }

            return "YES";
        }
    }
}
