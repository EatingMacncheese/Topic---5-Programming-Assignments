namespace Topic___5_Programming_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weight, planet;
            
            Console.WriteLine("how much to you weigh?");
            int.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine("select planet via number:");
            Console.WriteLine();
            Console.WriteLine("1. Venus  2. Mars   3. Jupiter");
            Console.WriteLine();
            Console.WriteLine("4. Saturn 5. Uranus 6. Neptune");
            int.TryParse(Console.ReadLine(), out planet);
            if (planet == 1)
            {
                Console.WriteLine("your weight is " + (weight * 0.9) + " on Venus");
            }
            else if (planet == 2)
            {
                Console.WriteLine("your weight is " + (weight * 0.38) + " on Mars");
            }
            else if (planet == 3)
            {
                Console.WriteLine("your weight is " + (weight * 2.4) + " on Jupiter");
            }
            else if (planet == 4)
            {
                Console.WriteLine("your weight is " + (weight * 1.08) + " on Saturn");
            }
            else if (planet == 5)
            {
                Console.WriteLine("your weight is " + (weight * 0.86) + " on Uranus");
            }
            else if (planet == 6) 
            {
                Console.WriteLine("your weight is " + (weight * 1.14) + " on Neptune");
            }
        }
    }
}
