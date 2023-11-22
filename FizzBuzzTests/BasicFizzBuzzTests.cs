using FizzBuzz;
using FizzBuzz.Service;
using FluentAssertions;

namespace FizzBuzzTests;

public class BasicFizzBuzzTests
{
    private readonly FizzBuzzService _sut;

    public BasicFizzBuzzTests()
    {
        _sut = new FizzBuzzService();
    }

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
    [TestCase("Fizz", 2)]
    [TestCase("Fizz", 98)]
    public void FizzBuzzBasic_ShouldReturnFizz_ForMultiplesOfThree(string expected, int loopNumber)
    {
        var result = _sut.FizzBuzzBasic();

        result[loopNumber].Should().Be(expected);
    }

    [Test]
    [TestCase("Buzz", 4)]
    [TestCase("Buzz", 99)]
    public void FizzBuzzBasic_ShouldReturnBuzz_ForMultiplesOfFive(string expected, int loopNumber)
    {
        var result = _sut.FizzBuzzBasic();

        result[loopNumber].Should().Be(expected);
    }
    
    [Test]
    [TestCase("FizzBuzz", 14)]
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

    [Test]
    public void FizzBuzzBasic_ShouldMatchProvidedList()
    {
        var expected = new []
        {
            "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11",
            "Fizz", "13", "14", "FizzBuzz", "16", "17", "Fizz", "19", "Buzz"
        };

        var result = _sut.FizzBuzzBasic().Take(20);

        result.Should().BeEquivalentTo(expected);
    }
}