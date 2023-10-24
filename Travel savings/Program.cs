namespace Travel_savings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double neededSum = double.Parse(Console.ReadLine());
                double collectedSum = 0;
                while (collectedSum < neededSum) {
                    collectedSum += double.Parse(Console.ReadLine());
                        Console.WriteLine($"Collected:{collectedSum :f2}");
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}