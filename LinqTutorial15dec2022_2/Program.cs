namespace LinqTutorial15dec2022_2;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = new[] { 1, 2, 3, 99, 256, 2 };
        bool isAnyLargerThan100 = IsAny(numbers, IsLargerThan100); // passing a function as a prameter
        bool isAnyEven = IsAny(numbers, IsEven);

        Console.WriteLine($"Is there any number > 100?: {isAnyLargerThan100}");
        Console.WriteLine($"Is there any number that is even?: {isAnyEven}");
    }


    private static bool IsLargerThan100(int number)
    {
        return number > 100;
    }
    private static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    //general pattern of a method:
    private static bool IsAny(int[] numbers, Func<int, bool> predicate
        /*a function is taking a number and returning a bool*/)
        // Func type that represents a function, first generic is the type of input parameter,
        // second is the type of return value
    {
        foreach (var number in numbers)
        {
            if (predicate(number)/*function(number)*/)
            {
                return true;
            }
        }
        return false;
    }
}