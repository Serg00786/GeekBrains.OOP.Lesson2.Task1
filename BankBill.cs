﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.OOP.Lesson2.Task1
{
    class BankBill
    {
        private long BillNumber;
        private double Balance;
        internal enum BillTypes{
             CompanyBill,
             PrivateBill
        }
        private BillTypes TheBillTypes;

        internal long GetBillNumber()
        {
            return BillNumber;
        }

        internal double GetBalance()
        {
            return Balance;
        }

        internal BillTypes GetBillTypes()
        {
            return TheBillTypes;
        }

        internal long SetBillNumber(long value)
        {
            return BillNumber = value;
        }

        internal double SetBalance(double value)
        {
            return Balance=value;
        }

        internal BillTypes SetBillTypes(BillTypes billTypes)
        {
            return TheBillTypes=BillTypes.CompanyBill;
        }
    }
}
