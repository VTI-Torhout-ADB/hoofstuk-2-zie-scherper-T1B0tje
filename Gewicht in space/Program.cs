namespace Gewicht_in_space
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gewichtOpAarde = 55;
            Console.WriteLine($"Je weegt op Mercurius {gewichtOpAarde * 0.38}N.");
            Console.WriteLine($"Je weegt op Venus {gewichtOpAarde * 0.91}N.");
            Console.WriteLine($"Je weegt op Aarde {gewichtOpAarde * 1.00}N.");
            Console.WriteLine($"Je weegt op Mars {gewichtOpAarde * 0.38}N.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Je weegt op Jupiter {gewichtOpAarde * 2.34}N.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Je weegt op Saturnus {gewichtOpAarde * 1.06}N.");
            Console.WriteLine($"Je weegt op uranus {gewichtOpAarde * 0.92}N.");
            Console.WriteLine($"Je weegt op Neptunus {gewichtOpAarde * 1.19}N.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Je weegt op Pluto {gewichtOpAarde * 0.06}N.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
