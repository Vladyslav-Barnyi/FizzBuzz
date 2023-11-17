using FizzBuzz;
using FluentAssertions;

namespace FizzBuzzTests;

public class AdvancedFizzBuzzTests
{
    [Fact]
    public void CheckEachForBeing_FizzBuzz()
    {
        var x = 1;
        var sut = Program.FizzBuzzAdvanced();
        
        foreach (var output in sut) {
            if (x % 3 == 0 && x % 5 == 0)
                output.Should().Contain("FizzBuzz");
            
            x++;
        }
    }
    
    [Fact]
    public void CheckEachForContaining_Fizz()
    {
        var x = 1;
        var sut = Program.FizzBuzzAdvanced();
        
        foreach (var output in sut) {
            if (x % 3 == 0 || x.ToString().Contains('3'))
                 output.Should().Contain("Fizz");
            
            x++;
        }
    }
    
    [Fact]
    public void CheckEachForContaining_Buzz()
    {
        var x = 1;
        var sut = Program.FizzBuzzAdvanced();
        
        foreach (var output in sut)
        {
            if (x % 5 == 0 || x.ToString().Contains('5'))
                output.Should().Contain("Buzz");
            
            x++;
        }
    }
}