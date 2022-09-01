namespace Katas.Range.Tests;

public class KataRangeTest
{
    [Test]
    public void should_throw_an_error_if_contains_letters()
    {

        Assert.That(() => new Range("(2,abc]"), Throws.ArgumentException);
    }

    [Test]
    public void range_input_should_be_equal_to_the_expected_value()
    {

        Assert.That(() => new Range("(2,6]"), Throws.Nothing);
    }


}
