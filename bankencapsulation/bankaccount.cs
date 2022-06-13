using System;
using System.Collections.Generic;
using System.Text;

namespace bankencapsulation
{
    public class bankaccount
    {
        private double balance = 0;
        
            
        
        public void deposit (double amount)
        {
            balance += amount; 
        }
        public double getbalance ()
        {
            return balance;
        }
        public void withdraw (double amount)
        {
            balance -= amount;
        }
    }
}
