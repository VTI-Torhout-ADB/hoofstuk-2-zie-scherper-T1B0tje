namespace Gemiddelde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int september = 240;
            int oktober = 230;
            int november = 260;
            int BTW = (september + oktober + november) / 3;
            Console.WriteLine(BTW);
        }
    }
}
