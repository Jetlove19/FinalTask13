using System.Diagnostics;

namespace FinalTask13
{
    public class Program
    {
        static void Main(string[] args)
        {
        var watch = Stopwatch.StartNew();

        List<string> list = new List<string>();
        list = File.ReadLines("C:/Users/Jetlove/Downloads/Text1 (1).txt").ToList();
            Console.WriteLine($"Вставка в List<T> заняла: {watch.Elapsed.TotalSeconds} мс");

            LinkedList<string> linkedlist = new LinkedList<string>();
            linkedlist.AddFirst(File.ReadAllText("C:/Users/Jetlove/Downloads/Text1 (1).txt"));
            Console.WriteLine($"Вставка в LinkedList<T> заняла: {watch.Elapsed.TotalMilliseconds} мс");
        }
    }
}