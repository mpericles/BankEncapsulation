﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;
     
        public void Deposit(double money) 
        {

            //_balance += money; - same as the statement below
            _balance = _balance + money;
        }
        public double GetBalance() 
        {
            return _balance;
        }
        //public void Withdraw (double amount) 
        //{
        //    _balance -= amount;
        //}
    }
}
