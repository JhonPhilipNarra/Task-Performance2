using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueueForm
{
    class CashierClass1
    {
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue;
        internal static object cashier;

        public CashierClass1()
        {
            x = 10000;
            CashierQueue = new Queue<string>();
        }
        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }
    }
}
