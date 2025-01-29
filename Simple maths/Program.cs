namespace Simple_maths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int antw1 = -1 + 4 * 6;
            Console.WriteLine($"-1 + 4 * 6 geeft {antw1}");
            int antw2 = (35 + 5) % 7;
            Console.WriteLine($"( 35 + 5 ) % 7 geeft {antw2}");
            double antw3 = 14 + -4 * 6 / 11.0;
            Console.WriteLine($"14 + -4 * 6 / 11 geeft {antw3}");
            double antw4 = 2 + 15 / 6.0 * 1 - 7 % 2;
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 geeft {antw4}");
        }
    }
}
