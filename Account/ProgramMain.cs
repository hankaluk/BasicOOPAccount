using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account {
    class ProgramMain {
        static void Main(string[] args) {
            Account ac1 = new Account("Lawrence", 5, 6, 1967, 2000);

            ac1.WriteInfo();

            ac1.InsertInto(-3000);

            Console.WriteLine();

            Account ac2 = new Account("Alexandra", 8, 3, 1982, 5000);

            ac1.WriteBalance();
            ac2.WriteBalance();

            ac1.TransferTo(ac1, 1000);
            ac1.TransferTo(ac2, 10000);
            ac1.TransferTo(ac2, -1000);
            
            ac1.WriteBalance();
            ac2.WriteBalance();

            Console.ReadKey();
        }
    }
}
