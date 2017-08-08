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
        public void input_25_50_should_return_YES()
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

        [TestMethod]
        public void input_25_25_50_50_should_return_YES()
        {
            PeopleInLineTicketShouldBe("YES", new[] { 25, 25, 50, 50 });
        }

        [TestMethod]
        public void input_25_25_25_25_25_100_100_should_return_No()
        {
            PeopleInLineTicketShouldBe("NO", new[] { 25, 25, 25, 25, 25, 100, 100 });
        }

        [TestMethod]
        public void input_25_25_25_25_50_100_50_should_return_Yes()
        {
            PeopleInLineTicketShouldBe("YES", new[] { 25, 25, 25, 25, 50, 100, 50 });
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
            var received25 = 0;
            var received50 = 0;
            foreach (var ticket in peopleInLine)
            {
                if (ticket == 25)
                {
                    received25++;
                }
                if (ticket == 50)
                {
                    received25--;
                    received50++;
                }
                if (ticket == 100)
                {
                    if (received50 == 0)
                    {
                        received25 -= 3;
                    }
                    else
                    {
                        received25--;
                        received50--;
                    }
                }

                if (received25 < 0 || received50 < 0)
                {
                    return "NO";
                }
            }

            return "YES";
        }
    }
}
