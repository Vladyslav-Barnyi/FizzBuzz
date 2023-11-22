namespace FizzBuzz.Service.Interface;

public interface IFizzBuzzService
{
    public List<string> FizzBuzzBasic();

    public List<string> FizzBuzzAdvance();

    public bool IsDividedBy3(int x);
    
    public bool IsDividedBy5(int x);
    
}