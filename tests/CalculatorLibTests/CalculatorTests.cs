using CalculatorLib;

namespace CalculatorLibTests;

public class CalculatorTests
{
    [Fact]
    public void TestAdd()
    {
        var calc = new Calculator();

        var result = calc.Add(3, 2);
        Assert.Equal(5, result);
    }
}