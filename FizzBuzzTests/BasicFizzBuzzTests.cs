namespace FizzBuzzTests;

public class BasicFizzBuzzTests
{
    [Theory]
    [InlineData(3)]
    [InlineData(0)]
    [InlineData(-15)]
    public void If_x_is_not_equal_to_1(int x)
    {
        var sut = FizzBuzz.Program.FizzBuzzBasic(x);
        
        var expected = new List<string> { "x must be equal to 1" };

        Assert.Equal(expected, sut);
    }
    
    [Fact]
    public void CheckEachForBeing_FizzBuzz()
    {
        var x = 1;
        var sut = FizzBuzz.Program.FizzBuzzBasic(x);
        
        foreach (var output in sut) {
            if (x % 3 == 0 && x % 5 == 0)
                Assert.Equal("FizzBuzz", output);
            
            x++;
        }
    }
    
    [Fact]
    public void CheckEachForContaining_Fizz()
    {
        var x = 1;
        var sut = FizzBuzz.Program.FizzBuzzBasic(x);
        
        foreach (var output in sut) {
            if (x % 3 == 0)
                Assert.Contains("Fizz", output);
            
            x++;
        }
    }
    
    [Fact]
    public void CheckEachForContaining_Buzz()
    {
        var x = 1;
        var sut = FizzBuzz.Program.FizzBuzzBasic(x);
        
        foreach (var output in sut)
        {
            if (x % 5 == 0)
                Assert.Contains("Buzz", output);
            
            x++;
        }
    }
}