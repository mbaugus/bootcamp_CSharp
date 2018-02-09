using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba1 = new BankAccount();
            ba1.AccountNumber = 222222;
            ba1.AccountType = "Checking";
            ba1.CustomerName = "Bob Smith";
            ba1.Balance = 903.10M;
        }

        class BankAccount
        {
            public int AccountNumber;
            private string ManagerComments;
            public decimal Balance;
            public string CustomerName;
            public string AccountType;
        }
        struct BankAccountStruct
        {

        }
    }
}
