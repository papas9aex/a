using Stack = ConsoleApp3.Stack;
using Pair = ConsoleApp3.Pair;

namespace ConsoleApp3
{

    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(3);
            intStack.Push(5);
            intStack.Push(2);
            int maxInt = intStack.Max();
            Console.WriteLine(maxInt);

            Stack<string?> stringStack = new Stack<string?>();
            stringStack.Push("apple");
            stringStack.Push("banana");
            stringStack.Push("cherry");
            string? maxString = stringStack.Max();
            Console.WriteLine(maxString);


            Pair.Pair<string, string> stringPair = new Pair.Pair<string, string>("Hello", "World");
            Console.WriteLine("String Pair: " + stringPair);


            Pair.Pair<string, SomeClass> mixedPair = new Pair.Pair<string, SomeClass>("Mixed", new SomeClass());
            Console.WriteLine("Mixed Pair: " + mixedPair);

            var calculator = Calculator<int>.CreateInstance();
            int sum = calculator.Add(3, 5);
            Console.WriteLine($"Cумма: " + sum);
            
            
            
        }

        public class SomeClass
        {

        }
    
}
}