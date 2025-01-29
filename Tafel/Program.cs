namespace Tafel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++)
            {
                int antwoord = i * 411;
                Console.WriteLine($"{i} x 411 = {antwoord}");
                Console.WriteLine("Druk enter om voort te gaan.");
                Console.ReadLine();
                Console.Clear();
            }
    }
}
