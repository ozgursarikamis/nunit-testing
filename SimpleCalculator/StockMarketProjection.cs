using System.Threading;

namespace Calculator
{
    public class StockMarketProjection
    {
        public decimal CalculateShortTerm()
        {
            return 200;
        }

        public decimal CalculateLongTerm()
        {
            Thread.Sleep(5000);
            return 50;
        }
    }
}