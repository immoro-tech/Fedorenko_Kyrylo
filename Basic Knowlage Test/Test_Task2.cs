using NUnit.Framework;


namespace task_2.Test
{
    public class Task2_test
    {
       

        [Test]
        public void FirstNonRepeat_String_ReturnFirstNonRepeatInThisString()
        {
            var str = "sTreSS";
                
            var result = Task_2.Loop.FirstNonRepeat(str);
            Assert.That(result, Is.EqualTo('T'));

        }

        [Test]

        public void FirstNonRepeat_EmptyString_ReturnsNull()
        {
            var str = "";
            var result = Task_2.Loop.FirstNonRepeat(str);
            Assert.That(result, Is.EqualTo(' '));
        }



    }
}