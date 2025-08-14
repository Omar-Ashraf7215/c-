namespace day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ////Account account = new Account();
            ////account.Maxvalue = 10000;
            //OutComeBankAccount InComeBankAccount = new OutComeBankAccount();
            //InComeBankAccount.Maxvalue = 10000;
            //InComeBankAccount.Balance = 2000;
            //Console.WriteLine("enter value 1 for deposit");
            //Console.WriteLine("enter value 2 for withdraw");
            //int operation = int.Parse(Console.ReadLine());

            //switch (operation)
            //{
            //    case 1:
            //        Console.WriteLine("enter value of deposit");
            //        int value = int.Parse(Console.ReadLine());
            //        InComeBankAccount.Deposit(value);
            //        break;
            //    case 2:
            //        Console.WriteLine("enter value of withdraw");
            //        int value2 = int.Parse(Console.ReadLine());
            //        InComeBankAccount.Deposit(value2);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid");
            //        break;
            //}
            Polymarphism polymarphism = new Polymarphism();
            Console.WriteLine($"Sum:{polymarphism.sum(3.2f, 3.3f)}");
        }
}
     class Account
    {
        
        //field
       private int _maxValue;
        private int _balance;
        public Account()
        {
            this._maxValue = 10000;
        }
        public int Maxvalue 
        {
            set 
            {
                if (value != 10000)
                {
                    Console.WriteLine("invalid");
                }
                _maxValue = value;
                
            }
            get 
            {
                return _maxValue;   
            }
                
        }

    }
}
