namespace LinqTutorial15dec2022_2;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = new[] { 1, 2, 3, 99, 256, 2 };
        bool isAnyLargerThan100 = IsAny(numbers, number => number > 100); // passing a function as a prameter
        bool isAnyEven = IsAny(numbers, number => number % 2 == 0);

        Console.WriteLine($"Is there any number > 100?: {isAnyLargerThan100}");
        Console.WriteLine($"Is there any number that is even?: {isAnyEven}");
    }



    //general pattern of a method:
    private static bool IsAny(int[] numbers, Func<int, bool> predicate /*the method declared with the lambda expression is used in place of this aprameter*/
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