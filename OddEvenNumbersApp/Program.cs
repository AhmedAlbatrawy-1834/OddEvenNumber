namespace OddEvenNumbersApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Hello, World!");
            printNumbers("Numbers", numbers);
            printNumbers("Even No", numbers.Where(x => IsEven(x)));
            printNumbers("Odd No", numbers.Where(x => IsOdd(x)));
        }
        static void printNumbers(string title, IEnumerable<int> numbers)
        {
            Console.WriteLine();
            Console.Write($"{title}:[");
            foreach (int i in numbers)
            {
                Console.Write(" " + i);
            }
            Console.Write(']');
            Console.WriteLine();
        }
        static bool IsEven(int value) => value % 2 == 0;
        static bool IsOdd(int value) => !IsEven(value);
        
    }
}
