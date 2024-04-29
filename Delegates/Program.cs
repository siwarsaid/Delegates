namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMoney sommeArgents = ShowMoneyEuro;
            Console.WriteLine("The sum in euros : " + sommeArgents(15, 35));
            sommeArgents = ShowMoneyDollar;
            Console.WriteLine("The sum in dollars : " + sommeArgents(15, 35));
        }

        public delegate double ShowMoney(double x,double y);

        public static double ShowMoneyEuro(double x,double y)
        {
            double euro=3.5;
            return (x+y) * euro;
            
        }

        public static double ShowMoneyDollar(double x,double y)
        {
            double dollars = 2.5;
            return (x+y) * dollars;

        }
    }
}
