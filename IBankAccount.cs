using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    public interface IBankAccount
    {
        public int Maxvalue { set; get; }
        public int Balance { get; set; }
        public string AccountNumber { set; get; }

        public abstract void Deposit(int value);

        public abstract void WithDraw(int value);
    }
     class OutComeBankAccount : IBankAccount
    {
        public int Maxvalue { set; get; }
        public int Balance { get; set; }
        public string AccountNumber { set; get; }

        public  void Deposit(int value)
        {
            if (value > Maxvalue)
            {
                Console.WriteLine("invalid");
                return;
            }
            Maxvalue += value;
        }
        public  void WithDraw(int value)
        {
            if (value > Balance)
            {
                Console.WriteLine("invalid");
                return;
            }
            Balance -= value;
        }
    }


}
