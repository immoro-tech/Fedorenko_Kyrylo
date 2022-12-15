namespace task_3.Test
{
    public class Tests
    {
        [TestCase(9, 9)]
        [TestCase(100, 1)]
        [TestCase(222, 6)]
        [TestCase(155, 2)]
        [TestCase(2412455, 5)]
        public void DigitalRootReturnsSumOfDigits_ContinuesUnlessLowerThan10(int number, int expectedResult)
        {
            var result = Task_3.Loop.digital_root(number);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}