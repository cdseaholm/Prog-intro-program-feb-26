

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("23", 23)]
    [InlineData("33", 33)]
    [InlineData("0", 0)]
    [InlineData("100", 100)]
    [InlineData("1000", 1000)]
    public void StringOfNumbersReturnsNumbers(string numStringForm, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numStringForm);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("0,1", 1)]
    [InlineData("0 , 1", 1)]
    [InlineData("10,1", 11)]
    [InlineData(" 10, 1", 11)]
    //#4 tests being added
    [InlineData("10, 1,1, 3", 15)]
    [InlineData("0,1,1,1,1 ,1", 5)]
    [InlineData("1, 2,2, 10, 2 ", 17)]
    //Adding tests for #5
    [InlineData("1\n2\n3", 6)]
    [InlineData("1\n2,3", 6)]
    [InlineData("1\n2,4", 7)]
    [InlineData("1\n2,3,3\n4", 13)]
    public void SplitAndParse(string inputString, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(inputString);
        Assert.Equal(expected, result);
    }
}
