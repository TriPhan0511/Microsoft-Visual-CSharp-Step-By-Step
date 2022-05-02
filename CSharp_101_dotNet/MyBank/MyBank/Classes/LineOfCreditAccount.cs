﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes;
public class LineOfCreditAccount : BankAccount
{
    //public LineOfCreditAccount(string name, decimal initialBalance) : base(name, initialBalance)
    //{
    //}

    public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit)
    {
    }

    public override void PerformMonthEndTransaction()
    {
        if (Balance < 0)
        {
            // Negate the balance to get a positive interest charge:
            decimal interest = -Balance * 0.07m;
            MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest.");
        }
    }
}

