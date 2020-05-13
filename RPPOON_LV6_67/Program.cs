using System;

namespace RPPOON_LV6_67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadatak 6:\n");
            StringChecker stringChecker = new StringDigitChecker();
            StringChecker stringLengthChecker = new StringLengthChecker(5);
            stringChecker.SetNext(stringLengthChecker);
            StringChecker stringUpperCaseChecker = new StringUpperCaseChecker();
            stringLengthChecker.SetNext(stringUpperCaseChecker);
            StringChecker stringLowerCaseChecker = new StringLowerCaseChecker();
            stringUpperCaseChecker.SetNext(stringLowerCaseChecker);
            string entered;
            do
            {
                Console.WriteLine("\nEnter password to try out or -1 to move to Task 7: ");
                entered = Console.ReadLine();
                if (entered != "-1") stringChecker.Check(entered);
            }
            while (entered != "-1");
            Console.Clear();
            Console.WriteLine("Zadatak 7:\n");
            PasswordValidator validator = new PasswordValidator(new StringDigitChecker());
            validator.AddCheck(new StringLengthChecker(5));
            validator.AddCheck(new StringUpperCaseChecker());
            validator.AddCheck(new StringLowerCaseChecker());
            do
            {
                Console.WriteLine("\nEnter password to try out or -1 to exit: ");
                entered = Console.ReadLine();
                if (entered != "-1") stringChecker.Check(entered);
            }
            while (entered != "-1");
            Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
        }
    }
}
