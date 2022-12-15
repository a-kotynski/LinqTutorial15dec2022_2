namespace LinqTutorial15dec2022_2;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = new[] { 1, 2, 3, 99, 256, 2 };
        //bool isAnyLargerThan100 = IsAnyLargerThan100(numbers);
        bool isAnyLargerThan100 = IsAny(numbers, IsLargerThan100); // passing a function as a prameter (not working example)
        //bool isAnyEven = IsAnyEven(numbers);
        bool isAnyEven = IsAny(numbers, IsEven);

        Console.WriteLine($"Is there any number > 100?: {isAnyLargerThan100}");
        Console.WriteLine($"Is there any number that is even?: {isAnyEven}");
    }

    private static bool IsAnyLargerThan100(int[] numbers)
    {
        foreach (var number in numbers)
        {
            if (IsLargerThan100(number))
            {
                return true;
            }
        }
        return false;
    }

    /*The below method is almost the same; the only thing that has changed is
     condition in if statement.
     If we follow the same logic with other conditions we end up with large amount
     of methods with nearly the same body of code.
     */

    private static bool IsAnyEven(int[] numbers)
    {
        foreach (var number in numbers)
        {
            if (IsLargerThan100(number))
            {
                return true;
            }
        }
        return false;
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