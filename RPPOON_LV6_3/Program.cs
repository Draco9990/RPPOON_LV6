using System;

namespace RPPOON_LV6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadatak 3: \n");
            CareTaker caretaker = new CareTaker();
            ToDoItem note = new ToDoItem("Rijesit LV6", "Rijesit LV6 iz RPPOONa", new DateTime(2020, 5, 14, 20, 00, 00));
            int choice;
            do
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("(1) - Print data");
                Console.WriteLine("(2) - Change title");
                Console.WriteLine("(3) - Change description");
                Console.WriteLine("(4) - Print saved data");
                Console.WriteLine("(5) - Store data");
                if (caretaker.Count() > 0)
                {
                    Console.WriteLine("(6) - Restore data");
                    Console.WriteLine("(7) - Clear saved data");
                }
                Console.WriteLine("(0) - Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(note.ToString());
                        break;
                    case 2:
                        Console.WriteLine("Enter new title: ");
                        note.Rename(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Enter new description: ");
                        note.ChangeTask(Console.ReadLine());
                        break;
                    case 4:
                        caretaker.PrintStates();
                        break;
                    case 5:
                        caretaker.StoreState(note.StoreState());
                        break;
                    case 6:
                        if (caretaker.Count() == 0) break;
                        caretaker.PrintStates();
                        Console.WriteLine("\nEnter restore point index: ");
                        note.RestoreState(caretaker.GetState(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case 7:
                        if (caretaker.Count() == 0) break;
                        caretaker.PrintStates();
                        Console.WriteLine("\nEnter restore point index or -1 to clear all: ");
                        int selection = Convert.ToInt32(Console.ReadLine());
                        if (selection == -1) caretaker.ClearAll();
                        else caretaker.DeleteState(selection);
                        break;
                }
            }
            while (choice != 0);
            Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
        }
    }
}
