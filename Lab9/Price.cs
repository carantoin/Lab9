using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Price
    {
        private double coins;
        public double Coins
        {
            get => coins;
            set { if (value > 0) coins = value; }
        }
        private double amount;
        public double Amount
        {
            get => amount;
            set { if (value > 0) amount = value; }
        }
        public Price(double coins, double a)
        {
            this.coins = coins;
        }
        public void Print()
        {
            Console.WriteLine($"");
        }
        public double GetPrice()
        {
            return coins * amount;
        }
    }
}
