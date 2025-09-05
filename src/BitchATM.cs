class BithATM
{
    static void Main()
    {
        Console.WriteLine("Welcome to BitchATM");
        string[] bitches = ["Mira", "Alex2", "Shrek","Lera"];
        Console.WriteLine("Choice your Bitch:");
        Console.WriteLine("1. Mira; 2. Alex2; 3. Shrek; 4. Darina");
        int ChoiceBitch = ReadLineToInt() - 1;
        string currency = bitches[ChoiceBitch] + "'s";
        int balance = 711;
        Console.WriteLine("Welcome to " + currency + " cum bank!");
        Thread.Sleep(1000);
        Console.WriteLine("Your balance is " + balance + " " + currency);
        Thread.Sleep(1000);
        Console.WriteLine("Please choose your transactions:(1-2)");
        Thread.Sleep(1000);
        Console.WriteLine("1. Deposit; 2. Withdraw");
        string[] transactions = ["Deposit", "Withdraw"];
        int ChoiceTransaction = ReadLineToInt() - 1;
        Console.WriteLine("Your choice is " + transactions[ChoiceTransaction] + ".");
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
        Thread.Sleep(1000);
        Console.WriteLine("Thank you for using " + currency + " cum bank!");
        Thread.Sleep(1000);
        Console.WriteLine("Have a bad day motherfucker!");
        Thread.Sleep(1000);

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
            Console.WriteLine("Invalid input... Choice your bitch:(1-6).");

        }
    }
}
