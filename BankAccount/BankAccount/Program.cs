using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account rony = new Savings("Rony", "01", 3000.0f);
            Account ahmed = new Current("Ahmed", "02", 2000f);
            Account md = new Fixed("MD", "03", 1000f, 2018, 10);

            Account a1 = new SuperSavings("Nusu", "04", 100f);
            a1.Withdraw(80);
            a1.ShowInfo();

            Account overdraft = new Overdraft("Rahman", "05", 1000f, 7000);
            overdraft.Transfer(a1, 5000);
            overdraft.ShowInfo();

            Customer customer = new Customer("Rony Ahmed");

        }
    }
}
