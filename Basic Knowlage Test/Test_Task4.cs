using NUnit.Framework;


namespace Task_4.Test;

    internal class Tests
{

    [TestCase(new int[] { 1, 2, 6, 9 }, 5)]
    [TestCase(new int[] { }, 1)]
    public static void CountPairsToSum_TargetCantBeReached(int[] arr, int target)
    {
        var result = Task_4.Loop.GetPairsCount(arr, target);
        Assert.That(result, Is.EqualTo(0));
    }

    [TestCase(new int[] { 1, 2, 3, 4 }, 5, 2)]
    [TestCase(new int[] { 1, 4, 6, 8 }, 12, 1)]
    [TestCase(new int[] { 2, 2, 2, 2 }, 4, 6)]
    [TestCase(new int[] { 1, 2, 2, 0, 3, 6, 4, 5 }, 5, 4)]
    public void CountPairsToSum_WithSumsEqualsTarget_ReturnsAmountOfPairs(int[] arr, int target, int expectedResult)
    {
        var result = Task_4.Loop.GetPairsCount(arr, target);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

}