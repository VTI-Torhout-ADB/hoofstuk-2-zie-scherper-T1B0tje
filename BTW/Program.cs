namespace BTW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prijs = 20;
            const double BTW = 21.0;
            double prijsMetBTW = prijs * ((BTW + 100) / 100);
            Console.WriteLine($"Prijs {prijs} euro zonder btw. Met BTW: {prijsMetBTW} euro.");
        }
    }
}
