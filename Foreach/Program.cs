namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Using For");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine("\n\nUsing Foreach");
            foreach (var n in numbers)
            {
                Console.Write($"{n} ");
            }

            Console.WriteLine("\n\nUsing Foreach Under The Hood");
            Foreach(numbers);

            Console.ReadKey();
        }

        static void Foreach<T>(IEnumerable<T> collection)
        {
            IEnumerator<T> enumerator = collection.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.Write($"{enumerator.Current} ");
            }

            enumerator.Dispose();
        }
    }
}
