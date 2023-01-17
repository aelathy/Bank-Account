// OOP Application Project - Arcade Accounts
#nullable disable
Console.Clear();
// List<bankAccount> accounts = new List<bankAccount>();
// accounts.Add(new bankAccount("John", "1964", "Teacher", 58, 1024.48, 1));
// accounts.Add(new bankAccount("Jeoe", "hello", "Engineer", 23, 4000.01, 2));
// accounts.Add(new bankAccount("Debby", "bank account", "Driver", 42, 200.41, 0.75));
// accounts.Add(new bankAccount("Jack", "password", "Entrepeneur", 18, 150.60, 1.25));
// accounts.Add(new bankAccount("Adam", "adam123", "Athlete", 28, 500.23, 2.5));


class bankAccount
{

    public string Name { get; set; }
    public string Password { get; set; }
    public string Job { get; set; }
    public int Age { get; set; }
    public double Money { get; set; }
    public double MoneyX { get; set; }

    public bankAccount(string name, string password, string job, int age, double money, double moneyX)
    {
        Name = name;
        Password = password;
        Job = job;
        Age = age;
        Money = money;
        MoneyX = moneyX;
    }

    public static void menuOptions()
    {
        Console.WriteLine("Main Menu");
        Console.WriteLine("1. Work");
        Console.WriteLine("2. Buy Food");
        Console.WriteLine("3. Buy Other");
        Console.WriteLine("4. Delete Account");
        Console.WriteLine("7. Exit");
    }


    public static void work(bankAccount currentAccount)
    {
        double payday = 200;
        currentAccount.Money += (payday *= currentAccount.MoneyX);
    }

    void buyFood(bankAccount currentAccount)
    {
        double cost = 50;
        currentAccount.Money -= (cost *= currentAccount.MoneyX);
    }

    void buyOther(bankAccount currentAccount)
    {
        double cost = 200;
        currentAccount.Money -= (cost *= currentAccount.MoneyX);
    }

    void deleteAccount(bankAccount account)
    {
    }

    public static void Main(String[] args)
    {
        List<bankAccount> accounts = new List<bankAccount>();
        accounts.Add(new bankAccount("John", "1964", "Teacher", 58, 1024.48, 1));
        accounts.Add(new bankAccount("Jeoe", "hello", "Engineer", 23, 4000.01, 2));
        accounts.Add(new bankAccount("Debby", "bank account", "Driver", 42, 200.41, 0.75));
        accounts.Add(new bankAccount("Jack", "password", "Entrepeneur", 18, 150.60, 1.25));
        accounts.Add(new bankAccount("Adam", "adam123", "Athlete", 28, 500.23, 2.5));

        //Prompt User
        Console.WriteLine("Welcome to your bank account");
        Console.WriteLine("Please log in using your name and passord.");
        Console.Write("Name: ");
        string nameInput = Console.ReadLine();
        Console.Write("Password: ");
        string passwordInput = Console.ReadLine();
        bool accountFound = false;

        while (!accountFound)
        {
            foreach (bankAccount account in accounts)
            {
                if (account.Name == nameInput && account.Password == passwordInput)
                {
                    bankAccount currentAccount = account;
                    accountFound = true;
                }
            }
            if (!accountFound)
                Console.WriteLine("Either name and/or password are incorrect, please try again.");
        }

        menuOptions();
    }
}

// class Program
// {

// }