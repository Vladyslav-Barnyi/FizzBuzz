using FizzBuzz.Service;

namespace FizzBuzz;

public class Program
{
    public static void Main()
    {
        var fizzBuzzService = new FizzBuzzService();
        var response = fizzBuzzService.FizzBuzzAdvance();
        foreach (var item in response)
        {
            Console.WriteLine(item);
        }
    }
}