namespace FizzBuzz;

public class Program
{
    public static List<string> FizzBuzzBasic(int x)
    {
        var result = new List<string>();
        ValidateInput(x, result);

        if (result.Count > 0)
            return result;

        while (x < 100)
        {
            var output = string.Empty;
            if (IsDividedBy3(x))
                output = "Fizz";

            if (IsDividedBy5(x))
                output += "Buzz";

            result.Add(!string.IsNullOrEmpty(output) ? output : x.ToString());
            x++;
        }

        return result;
    }

    private static void ValidateInput(int x, ICollection<string> result)
    {
        if (x != 1)
            result.Add("x must be equal to 1");
    }

    private static bool IsDividedBy3(int x)
    {
        return x % 3 == 0;
    }

    private static bool IsDividedBy5(int x)
    {
        return x % 5 == 0;
    }

    public static void Main()
    {
        var response = FizzBuzzAdvanced();
        foreach (var item in response)
        {
            Console.WriteLine(item);
        }
    }

    public static List<string> FizzBuzzAdvanced()
    {
        var result = new List<string>();
        var x = 1;
        while (x < 100)
        {
            var output = string.Empty;
            if (IsDividedBy3(x))
                output = "Fizz";

            if (IsDividedBy5(x))
                output += "Buzz";

            if (x.ToString().Contains('3'))
                output = "Fizz" + output;

            if (x.ToString().Contains('5'))
                output += "Buzz";

            result.Add(!string.IsNullOrEmpty(output) ? output : x.ToString());
            x++;
        }

        return result;
    }
}