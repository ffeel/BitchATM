class BithATM
{
    static void Main()
    {
        Console.WriteLine("Welcome to BitchATM");
        Thread.Sleep(1200);
        string[] bitches = ["Mira", "Alex2", "Shrek","Lera"];
        Thread.Sleep(1200);
        Console.WriteLine("Choice your Bitch:");
        Thread.Sleep(1200);
        Console.WriteLine("1. Mira; 2. Alex2; 3. Shrek; 4. Lera");
        Thread.Sleep(3200);
        Console.WriteLine("Think faster, idiot.");
        Thread.Sleep(2500);
        Console.WriteLine("As for me, Lera is the best in terms of price-quality ratio.");
        int ChoiceBitch = ReadLineToInt() - 1;
        string currency = bitches[ChoiceBitch] + "'s";
        Random rand = new Random();
        int randomNumber = rand.Next();
        int balance = (randomNumber);
        Console.WriteLine("Welcome to " + currency + " cum bank!");
        Thread.Sleep(1500);
        Console.WriteLine("Your balance is " + balance + " " + currency);
        Thread.Sleep(1500);
        Console.WriteLine("Please choose your transactions:(1-2)");
        Thread.Sleep(1500);
        Console.WriteLine("1. Deposit; 2. Withdraw");
        string[] transactions = ["Deposit", "Withdraw"];
        int ChoiceTransaction = ReadLineToInt() - 1;
        Console.WriteLine("Ok your choice is " + transactions[ChoiceTransaction] + ".");
        Thread.Sleep(1000);
        if (ChoiceTransaction == 0)
        {
            Console.WriteLine("Please enter your deposit amount: ");
            int deposit = ReadLineToInt();
            balance += deposit;
        }
        else if (ChoiceTransaction == 1)
        {
            Console.WriteLine("Please enter your withdraw amount: ");
            int withdraw = ReadLineToInt();
            balance -= withdraw;
        }
        else
        {
            Console.WriteLine("Invalid input... ");
        }

        Console.WriteLine("Your balance is " + balance + " " + currency);
        Thread.Sleep(1500);
        Console.WriteLine("Please choose your transactions or shut down:(1-3)");
        Thread.Sleep(1500);
        Console.WriteLine("1. Deposit; 2. Withdraw; 3. Shut down");
        string[] transactions2 = ["Deposit", "Withdraw", "Shut down"];
        int ChoiceTransaction2 = ReadLineToInt() - 1;
        if (ChoiceTransaction2 == 2)
        {
            Console.WriteLine("Shutting down...");
            Thread.Sleep(1500);
        }
        else if (ChoiceTransaction2 == 0)
        {
            Console.WriteLine("Please enter your deposit amount: ");
            int deposit = ReadLineToInt();
            balance += deposit;
        }
        else if (ChoiceTransaction2 == 1)
        {
            Console.WriteLine("Please enter your withdraw amount: ");
            int withdraw = ReadLineToInt();
            balance -= withdraw;
        }
        else
        {
            Console.WriteLine("Invalid input... ");
        }
        Console.WriteLine("Thank you for using " + currency + " cum bank!");
        Thread.Sleep(1500);
        Console.WriteLine("Have a terrible day, asshole!");
        Thread.Sleep(1500);

    }

    static int ReadLineToInt()
    {
        int result;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out result))
            {
                return result;
            }
            Console.WriteLine("Invalid input... Choice your bitch:(1-4).");

        }
    }
}
