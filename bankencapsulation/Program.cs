using System;

namespace bankencapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var acc1 = new bankaccount();

            acc1.deposit(100.50);            

            acc1.withdraw(50.50);

            var balance = acc1.getbalance();

            Console.WriteLine(balance);
        }
    }
}
