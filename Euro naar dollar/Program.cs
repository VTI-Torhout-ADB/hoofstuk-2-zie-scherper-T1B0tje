namespace Euro_naar_dollar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bedragInEuro = 78.65;
            double bedragInDollar = bedragInEuro * 1.01;
            Console.WriteLine($"{bedragInEuro} Eur is gelijk aan {bedragInDollar} USD");
        }
    }
}
