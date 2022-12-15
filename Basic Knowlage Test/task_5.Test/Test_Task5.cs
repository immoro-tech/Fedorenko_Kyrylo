using NUnit.Framework;


namespace Task_5.Test
{
    public class Tests
    {
        [Test]
        public void Task5()
        {
            string expected = "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";
            string actual = ("Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill");
            string result = Loop.FriendList(actual);
            Assert.That(result, Is.EqualTo(expected));
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