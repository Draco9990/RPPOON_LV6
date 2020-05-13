using System;

namespace RPPOON_LV6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadatak 4: \n");
            CareTaker caretaker = new CareTaker();
            BankAccount account = new BankAccount("Marino Sismanovic", "Hrvatska", 100);
            int choice;
            do
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("(1) - Print data");
                Console.WriteLine("(2) - Change address");
                Console.WriteLine("(3) - Update balance");
                Console.WriteLine("(4) - Print saved data");
                Console.WriteLine("(5) - Store data");
                if (caretaker.Count() > 0)
                    Console.WriteLine("(6) - Restore data");
                Console.WriteLine("(0) - Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(account.ToString());
                        break;
                    case 2:
                        Console.WriteLine("Enter new address: ");
                        account.ChangeOwnerAddress(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Enter amount to top up: ");
                        decimal balance;
                        if (decimal.TryParse(Console.ReadLine(), out balance))
                            account.UpdateBalance(balance);
                        else
                            Console.WriteLine("Invalid value!");
                        break;
                    case 4:
                        caretaker.PrintStates();
                        break;
                    case 5:
                        caretaker.StoreState(account.StoreState());
                        break;
                    case 6:
                        if (caretaker.Count() == 0) break;
                        caretaker.PrintStates();
                        Console.WriteLine("\nEnter restore point index: ");
                        account.RestoreState(caretaker.GetState(Convert.ToInt32(Console.ReadLine())));
                        break;
                }
            }
            while (choice != 0);
            Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
        }
    }
}
