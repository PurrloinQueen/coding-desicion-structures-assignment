namespace topic_5_desicion_structures_assignment
{
    internal class Program
    {
        public static void BlorbBank()
        {
            double bankAccount, userDeposit, userWithdrawal;
            int atmAction;

            bankAccount = 150;
            Console.WriteLine("Welcome to the BoB; bank of Blorb.");
            Thread.Sleep(500);
            Console.WriteLine("How would you like to proceed?");
            Thread.Sleep(500);
            Console.WriteLine("1) DEPOSIT");
            Thread.Sleep(500);
            Console.WriteLine("2) WITHDRAWAL");
            Thread.Sleep(500);
            Console.WriteLine("3) BILL PAYMENT");
            Thread.Sleep(500);
            Console.WriteLine("4) SAVINGS UPDATE");
            Console.WriteLine("Please input a number.");
            atmAction = Convert.ToInt32(Console.ReadLine());
            if (atmAction == 1)
            {
                Console.WriteLine($"You currently have {bankAccount} dollars in your account.");
                Console.WriteLine("What would you like to deposit?");
                userDeposit = Convert.ToDouble(Console.ReadLine());
                if (userDeposit >= 0)
                {
                    bankAccount = bankAccount + userDeposit;

                    bankAccount = bankAccount - 0.75;
                }
                else
                {
                    Console.WriteLine("Invalid Amount.");
                    bankAccount = bankAccount - 0.75;
                }
                Console.WriteLine($"Your balance is now {bankAccount}.");

            }
            else if (atmAction == 2)
            {
                Console.WriteLine($"You currently have {bankAccount} dollars in your account.");
                Console.WriteLine("What would you like to withdraw?");
                userWithdrawal = Convert.ToDouble(Console.ReadLine());
                if (userWithdrawal <= 150 && userWithdrawal >= 0)
                {
                    bankAccount = bankAccount - userWithdrawal;
                    bankAccount = bankAccount - 0.75;
                }
                else
                {
                    Console.WriteLine("Invalid Amount.");
                    bankAccount = 0.75;
                }
                Console.WriteLine($"Your balance is now {bankAccount}.");
            }
            else if (atmAction == 3)
            {

            }
        }
        
        static void Main(string[] args)
        {

        }
    }
}