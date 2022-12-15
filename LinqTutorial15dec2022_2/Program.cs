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

        var words = new[] { "aaa", "BBB", "ccc" };
        bool isAnyOfLength4 = IsAny(words, word => word.Length == 4);

    }


    /*It's also possible to store a lambda expression in a variable: */
    Func<int,bool> isAnyEvenFunc = number => number % 2 == 0;
    //general pattern of a method:
    private static bool IsAny<T>(IEnumerable<T> numbers, Func<T, bool> predicate /*the method declared with the lambda expression is used in place of this aprameter*/
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