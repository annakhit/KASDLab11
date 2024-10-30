using System;

namespace KASDLab11
{
    internal class Program
    {
        static void Main()
        {
            MyPriorityQueue<int> queue = new MyPriorityQueue<int>();

            queue.Add(1, 5);
            queue.Add(11, 5);
            queue.Add(4, 11);
            queue.Add(5);
            queue.Add(6, 11);

            queue.Print();

            Console.WriteLine();

            Console.WriteLine(queue.Contains(15));

            queue.Remove(4);

            queue.Print();
            Console.WriteLine();

            queue.Poll();

            queue.Print();

            Console.ReadKey();
        }
    }
}
