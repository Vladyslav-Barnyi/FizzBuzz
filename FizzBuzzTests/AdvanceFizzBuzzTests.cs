using FizzBuzz.Service;
using FluentAssertions;

namespace FizzBuzzTests;

public class AdvanceFizzBuzzTests
{

    private readonly FizzBuzzService _sut;

    public AdvanceFizzBuzzTests()
    {
        _sut = new FizzBuzzService();
    }
    
    [Test]
    [TestCase("Fizz", 12)]
    [TestCase("Fizz", 22)]
    public void FizzBuzzAdvanced_ShouldReturnFizz_IfNumberContains3(string expected, int loopNumber)
    {
        var result = _sut.FizzBuzzAdvance();

        result[loopNumber].Should().Be(expected);
    }
    
    [Test]
    [TestCase("Buzz", 51)]
    [TestCase("Buzz", 55)]
    public void FizzBuzzAdvanced_ShouldReturnBuzz_IfNumberContains5(string expected, int loopNumber)
    {
        var result = _sut.FizzBuzzAdvance();

        result[loopNumber].Should().Be(expected);
    }
    
    [Test]
    [TestCase("FizzFizz", 2)]
    [TestCase("FizzFizz", 92)]
    public void FizzBuzzAdvanced_ShouldReturnFizzFizz_IfNumberContains3andIsMultipleOf3(string expected, int loopNumber)
    {
        var result = _sut.FizzBuzzAdvance();

        result[loopNumber].Should().Be(expected);
    }
    
    [Test]
    [TestCase("BuzzBuzz", 4)]
    [TestCase("BuzzBuzz", 94)]
    public void FizzBuzzAdvanced_ShouldReturnBuzzBuzz_IfNumberContains5AndIsMultipleOf5(string expected, int loopNumber)
    {
        var result = _sut.FizzBuzzAdvance();

        result[loopNumber].Should().Be(expected);
    }
    
    [Test]
    [TestCase("FizzFizzBuzz", 29)]
    public void FizzBuzzAdvanced_ShouldReturnFizzFizz_IfNumberContains3andContains5andIsMultipleOf3(string expected, int loopNumber)
    {
        var result = _sut.FizzBuzzAdvance();

        result[loopNumber].Should().Be(expected);
    }
    
    [Test]
    [TestCase("FizzBuzzBuzz", 14)]
    [TestCase("FizzBuzzBuzz", 74)]
    public void FizzBuzzAdvanced_ShouldReturnBuzzBuzz_IfNumberContains3andContains5AndIsMultipleOf5(string expected, int loopNumber)
    {
        var result = _sut.FizzBuzzAdvance();

        result[loopNumber].Should().Be(expected);
    }
    
    [Test]
    public void FizzBuzzBasic_ShouldMatchProvidedList()
    {
        var expected = new []
        {
            "1", "2", "FizzFizz", "4", "BuzzBuzz", "Fizz", "7", "8", "Fizz", "Buzz", "11",
            "Fizz", "Fizz", "14", "FizzBuzzBuzz", "16", "17", "Fizz", "19", "Buzz"
        };

        var result = _sut.FizzBuzzAdvance().Take(20);

        result.Should().BeEquivalentTo(expected);
    }
    #region basicTests

    [Test]
    [TestCase(33,true)]
    [TestCase(77,false)]
    public void IsDividedBy3_Should_ReturnExpectedBool(int number, bool expected)
    {
        var actual = _sut.IsDividedBy3(number);

        actual.Should().Be(expected);
    }
    
    [Test]
    [TestCase(55,true)]
    [TestCase(77,false)]
    public void IsDividedBy5_Should_ReturnExpectedBool(int number, bool expected)
    {
        var actual = _sut.IsDividedBy5(number);

        actual.Should().Be(expected);
    }

    [Test]
    [TestCase("Fizz", 5)]
    [TestCase("Fizz", 98)]
    public void FizzBuzzBasic_ShouldReturnFizz_ForMultiplesOfThree(string expected, int loopNumber)
    {
        var result = _sut.FizzBuzzBasic();

        result[loopNumber].Should().Be(expected);
    }

    [Test]
    [TestCase("Buzz", 9)]
    [TestCase("Buzz", 99)]
    public void FizzBuzzBasic_ShouldReturnBuzz_ForMultiplesOfFive(string expected, int loopNumber)
    {
        var result = _sut.FizzBuzzBasic();

        result[loopNumber].Should().Be(expected);
    }
    
    [Test]
    [TestCase("FizzBuzz", 59)]
    [TestCase("FizzBuzz", 89)]
    public void FizzBuzzBasic_ShouldReturnFizzBuzz_ForMultiplesOfThreeAndFive(string expected, int loopNumber)
    {
        var result = _sut.FizzBuzzBasic();

        result[loopNumber].Should().Be(expected);
    }
    
    [Test]
    [TestCase("1", 0)]
    [TestCase("98", 97)]
    public void FizzBuzzBasic_ShouldReturnSameNumber_ForNonMultiplesOfThreeAndFive(string expected, int loopNumber)
    {
        var result = _sut.FizzBuzzBasic();

        result[loopNumber].Should().Be(expected);
    }

    #endregion   
    
}