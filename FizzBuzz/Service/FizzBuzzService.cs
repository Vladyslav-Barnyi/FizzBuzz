using FizzBuzz.Service.Interface;

namespace FizzBuzz.Service;

public class FizzBuzzService : IFizzBuzzService
{
    public List<string> FizzBuzzBasic()
    {
        var result = new List<string>();

        for (var i = 1; i < 101; i++)
        {
            var output = string.Empty;
            
            if (IsDividedBy3(i))
                output = "Fizz";

            if (IsDividedBy5(i))
                output += "Buzz";
            
            result.Add(!string.IsNullOrEmpty(output) ? output : i.ToString());
        }

        return result;
    }

    public List<string> FizzBuzzAdvance()
    {
        var result = new List<string>();
        
        for (var i = 1; i < 101; i++)
        {
            var output = string.Empty;
            
            if (IsDividedBy3(i))
                output = "Fizz";

            if (IsDividedBy5(i))
                output += "Buzz";

            if (i.ToString().Contains('3'))
                output = "Fizz" + output;

            if (i.ToString().Contains('5'))
                output += "Buzz";

            result.Add(!string.IsNullOrEmpty(output) ? output : i.ToString());
        }

        return result;
    }

    public bool IsDividedBy3(int x)
    {
        return x % 3 == 0;
    }

    public bool IsDividedBy5(int x)
    {
        return x % 5 == 0;
    }
}