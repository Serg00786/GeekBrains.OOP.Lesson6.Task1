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

        public static bool operator ==(BankBill b1, BankBill b2)
        {
            bool isb1null = ReferenceEquals(b1, null);
            bool isb2null = ReferenceEquals(b2, null);

            if(!isb1null && !isb2null && b1.Balance == b2.Balance)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool operator !=(BankBill b1, BankBill b2)
        {
            if (b1.Balance != b2.Balance)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "new result";
        }
    }
}
