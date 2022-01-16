using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.OOP.Lesson2.Task1
{
    class BankBill
    {
        internal long BillNumber {get; set; }
        internal double Balance {get; set; }

        internal enum BillTypes{
             CompanyBill,
             PrivateBill
        }
        private BillTypes _BillTypes;

        internal BillTypes CurrentBillTypes
        {
            get { return _BillTypes; }
            set { _BillTypes = value; }
        }

        internal double FromDeposite(double IncomingSum)
        {
            if (Balance > IncomingSum)
            {

                return Balance-IncomingSum;
            }
            else
            {
                return Balance;
            }
        }

        internal double ToDeposite(double IncomingSum)
        {
            return Balance+IncomingSum;
        }

        internal string Transaction(BankBill bankBill, int sum)
        {
            return "Transferred succesfully";
        }
    }
}
