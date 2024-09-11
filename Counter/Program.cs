namespace Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter(7); //Start value

            counter.Increment();
            counter.Increment();
            counter.Increment();

            Console.WriteLine("Counter: " + counter.GetCount());
            counter.Reset();

            Console.WriteLine("Counter: " + counter.GetCount());
            counter.IncrementBy(5);

            Console.WriteLine("Counter: " + counter.GetCount());
        }
    }
}
