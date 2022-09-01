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

    [Test]
    public void throw_an_error_if_the_value_received_is_a_character() 
    {
        Assert.That(() => new Range("."), Throws.ArgumentException);
    }

    [Test]
    public void throw_an_error_if_input_has_a_symbol_that_is_not_a_coma()
    {
        Assert.That(() => new Range("(2/3]"), Throws.ArgumentException);

    }

}
