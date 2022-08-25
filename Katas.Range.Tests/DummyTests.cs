namespace Katas.Range.Tests;

public class DummyTests
{
    [Test]
    public void TheOnlyAnswer_Is_42()
    {
        TheRobot theRobot = new();

        Assert.That(theRobot.TheOnlyAnswer(), Is.EqualTo(42));
    }
}
