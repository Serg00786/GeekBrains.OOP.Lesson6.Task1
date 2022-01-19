using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.OOP.Lesson2.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankBill bankBill = new BankBill();
            bankBill.Balance = 1111;
            bankBill.BillNumber = 22222;
            bankBill.CurrentBillTypes = BankBill.BillTypes.CompanyBill;
            
            var balance = bankBill.FromDeposite(11);
            Console.WriteLine(balance);

            balance = bankBill.ToDeposite(1100);
            Console.WriteLine(balance);

            int sum = 1000;

            if (balance > sum)
            {
               string result= bankBill.Transaction(bankBill, sum);
                Console.WriteLine(result);
            }

            BankBill bankbil2 = new BankBill();
            bankbil2.Balance = 1111;
           
            

            Console.WriteLine("BankBill.Equals(Bankbil2) = {0}", bankBill.Equals(bankbil2));
            Console.WriteLine("Bankbill == BankBil2 = {0}", bankBill == bankbil2);
            Console.WriteLine("BankBil != BankBil2 = {0}", bankBill != bankbil2);
            Console.WriteLine(bankBill.Equals(bankbil2).ToString());




            Console.ReadKey();
        }
    }
}
