namespace topic_5_desicion_structures_assignment
{
    internal class Program
    {
        public static void BlorbBank()
        {
            double bankAccount, userDeposit, userWithdrawal, billPay;
            int atmAction;
            Random generator = new Random();  

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
                    bankAccount = bankAccount - 0.75;
                }
                Console.WriteLine($"Your balance is now {bankAccount}.");
            }
            else if (atmAction == 3)
            {
                Console.WriteLine("Enter the amount of money needed to pay bill.");
                billPay = Convert.ToDouble(Console.ReadLine());
                bankAccount = bankAccount - 0.75;
                if (billPay <= bankAccount && billPay >= 0)
                {
                    bankAccount = bankAccount - billPay;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Money required for bill is greater than account balance.");
                }
                Console.WriteLine($"Your balance is now {bankAccount}.");
            }
            else if (atmAction == 4)
            {
                Console.WriteLine($"Your balance is currently {bankAccount}.");
            }
        }

        public static void Garage()
        {
            int carTime;
            double firstFee, additionalFee, maxFee, totalFees;

            maxFee = 20.00;
            firstFee = 4.00;
            additionalFee = 2.00;
            
            Console.WriteLine("Welcome to Sam's Parking Garage!");
            Console.WriteLine("Your vehicle is in safe hands, don't worry!");
            Console.WriteLine("How many minutes will you be leaving your vehicle here for?");
            carTime = Convert.ToInt32(Console.ReadLine());
            if ( carTime >= 1440)
            {
                Console.WriteLine("That's over 24 hours...");
                Console.WriteLine("Unfortunately we don't provide service for longer than 1 day! Sorry.");
                Console.WriteLine("If you're doing something more short-term, be sure to come back!");
                Thread.Sleep(2000);
                Garage();
            }
            else if (carTime <= 0)
            {
                Console.WriteLine("...dude. If you're gonna be gone for less than a minute you don't need to leave your car here?");
                Console.WriteLine("I'll give you the benefit of the doubt and say you don't know how to convert hours into minutes, let's try this again.");
                Garage();
            }
            else
            {
                Console.WriteLine("Alright, take care! You can pay when you return!");
                Thread.Sleep(2000);
                carTime = carTime / 60;
                totalFees = firstFee + (additionalFee * carTime);
                Console.WriteLine("Welcome back!");
                Console.WriteLine("We made sure to keep your car in good shape!");
                Console.WriteLine($"Your total is {totalFees}. Thanks for your patronage!");
            }
            
        }
        
        public static void ExtremeWeather()
        {
            int uhOh, mph, kt, km;
            Random generator = new Random();
            
            Console.WriteLine("Hurricane Category Analyzer.");
            Console.WriteLine("What category is the hurricane happening currently or about to pass over?");
            uhOh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wind Speeds");
            if (uhOh == 1)
            {
                mph = generator.Next(74, 96);
                kt = generator.Next(64, 83);
                km = generator.Next(119, 154);
                Console.WriteLine($"{mph} miles per hour. {kt} knots. {km} kilometers per hour.");
                Console.WriteLine("Stay safe. It looks rough out there.");
            }
            else if (uhOh == 2)
            {
                mph = generator.Next(96, 111);
                kt = generator.Next(83, 96);
                km = generator.Next(154, 178);
                Console.WriteLine($"{mph} miles per hour. {kt} knots. {km} kilometers per hour.");
                Console.WriteLine("Stay safe. It looks rough out there.");
            }
            else if (uhOh == 3)
            {
                mph = generator.Next(111, 131);
                kt = generator.Next(96, 114);
                km = generator.Next(178, 210);
                Console.WriteLine($"{mph} miles per hour. {kt} knots. {km} kilometers per hour.");
                Console.WriteLine("Stay safe. It looks rough out there.");
            }
            else if (uhOh == 4)
            {
                mph = generator.Next(131, 156);
                kt = generator.Next(114, 136);
                km = generator.Next(210, 250);
                Console.WriteLine($"{mph} miles per hour. {kt} knots. {km} kilometers per hour.");
                Console.WriteLine("Stay safe. It looks rough out there.");
            }
            else if (uhOh == 5)
            {
                Console.WriteLine("Inable to pick up wind speed due to severity.");
                Console.WriteLine("Numbers are going over 155 mph, 135 kt, and 249 km/hr.");
                Console.WriteLine("Stay safe. It looks rough out there.");
            }
            else
            {
                Console.WriteLine("Error.");
                Thread.Sleep(500);
                Console.WriteLine("Number entered is not valid Hurricane Category number.");
                Thread.Sleep(500);
                Console.WriteLine("Returning to Title Screen.");
                Thread.Sleep(2000);
                ExtremeWeather();
            }
            
        }
        
        static void Main(string[] args)
        {
            int userChoice;

            Console.WriteLine("Topic 5 - desicion structures");
            Thread.Sleep(1000);
            Console.WriteLine("code by Kayleigh Mortimer.");
            Thread.Sleep(1000);
            Console.WriteLine("Please choose a number between 1, 2, or 3.");
            userChoice = Convert.ToInt32(Console.ReadLine());
            if (userChoice == 1)
            {
                BlorbBank();
            }
            else if (userChoice == 2)
            {
                Garage();
            }
            else if (userChoice == 3) 
            {
                ExtremeWeather();
            }
            else
            {
                Console.WriteLine("Error. Please select a number between 1, 2, or 3.");
                Thread.Sleep(500);
                Console.WriteLine("Try again.");
                userChoice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}