namespace FizzBuzzTests;

public class AdvancedFizzBuzzTests
{
    [Fact]
    public void CheckEachForBeing_FizzBuzz()
    {
        var x = 1;
        var sut = FizzBuzz.Program.FizzBuzzAdvanced();
        
        foreach (var output in sut) {
            if (x % 3 == 0 && x % 5 == 0)
                Assert.Contains("FizzBuzz", output);
            
            x++;
        }
    }
    
    [Fact]
    public void CheckEachForContaining_Fizz()
    {
        var x = 1;
        var sut = FizzBuzz.Program.FizzBuzzAdvanced();
        
        foreach (var output in sut) {
            if (x % 3 == 0 || x.ToString().Contains('3'))
                Assert.Contains("Fizz", output);
            
            x++;
        }
    }
    
    [Fact]
    public void CheckEachForContaining_Buzz()
    {
        var x = 1;
        var sut = FizzBuzz.Program.FizzBuzzAdvanced();
        
        foreach (var output in sut)
        {
            if (x % 5 == 0 || x.ToString().Contains('5'))
                Assert.Contains("Buzz", output);
            
            x++;
        }
    }
}