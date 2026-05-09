namespace Excellent;

public class Main
{
    public string EvenOrOdd(int number)
    {
        if (number % 2 == 0)
        {
            return "even";
        }
        throw new NotImplementedException("unimplemented");
    }
}
