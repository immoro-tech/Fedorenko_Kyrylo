using NUnit.Framework;


namespace Task_5.Test
{
    public class Tests
    {
        [Test]
        public void ChangeFriendList__ReturnsRequiredOutput()
        {
            var s = "Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
            var requiredResult = "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";
            string result = Task_5.Loop.FriendList(s);
            Assert.That(result, Is.EqualTo(requiredResult));
        }

        [TestCase("")]
        [TestCase("::;;")]
        public void ChangeFriendList_WrongFormat_ThrowsException(string s)
        {
            TestDelegate action = () => Task_5.Loop.FriendList(s);
            Assert.Throws<Exception>(action);
        }
    }
}