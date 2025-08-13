namespace Assignment_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Customer> queue = new();

            string[]? names = { null, "Vincent Xu", "John Cena" };

            foreach(var name in names)
            {
                queue.Enqueue(new Customer { Name = name });
            }

            Console.WriteLine("Display():");
            queue.Display();

            Console.WriteLine($"Dequeue(): {queue.Dequeue()}");
            Console.WriteLine("Display():");
            queue.Display();

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            try
            {
                queue.Dequeue();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Display():");
            queue.Display();
        }
    }
}
