using FizzBuzz;
using FluentAssertions;

namespace FizzBuzzTests;

public class BasicFizzBuzzTests
{

    [Theory]
    [InlineData(3)]
    [InlineData(0)]
    [InlineData(-15)]
    public void If_x_is_not_equal_to_1(int x)
    {
        var sut = Program.FizzBuzzBasic(x);
        
        var expected = new List<string> { "x must be equal to 1" };

        expected.Should().BeEquivalentTo(sut);
    }
    
    [Fact]
    public void CheckEachForBeing_FizzBuzz()
    {
        var x = 1;
        var sut = Program.FizzBuzzBasic(x);
        
        foreach (var output in sut) {
            if (x % 3 == 0 && x % 5 == 0)
                output.Should().BeEquivalentTo("FizzBuzz");
            
            x++;
        }
    }
    
    [Fact]
    public void CheckEachForContaining_Fizz()
    {
        var x = 1;
        var sut = Program.FizzBuzzBasic(x);
        
        foreach (var output in sut) {
            if (x % 3 == 0)
                output.Should().Contain("Fizz");
            
            x++;
        }
    }
    
    [Fact]
    public void CheckEachForContaining_Buzz()
    {
        var x = 1;
        var sut = Program.FizzBuzzBasic(x);
        
        foreach (var output in sut)
        {
            if (x % 5 == 0)
                output.Should().Contain("Buzz");
            
            x++;
        }
    }
}