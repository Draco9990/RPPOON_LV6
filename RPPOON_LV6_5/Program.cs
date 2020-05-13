using System;

namespace RPPOON_LV6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadatak 5: \n");
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, @"C:\logFile.txt");
            logger.SetNextLogger(fileLogger);
            first:
            Console.WriteLine("\nEnter message to log: ");
            string msg = Console.ReadLine();
            start:
            Console.WriteLine("\n(1) Type - Error");
            Console.WriteLine("(2) Type - Info");
            Console.WriteLine("(3) Type - Warning");
            Console.WriteLine("Enter number for logging type: ");
            int numb;
            MessageType type;
            if (int.TryParse(Console.ReadLine(), out numb))
            {
                switch(numb)
                {
                    case 1: type = MessageType.ERROR; break;
                    case 2: type = MessageType.INFO; break;
                    case 3: type = MessageType.WARNING; break;
                    default: goto start;
                }
            }
            else goto start;
            Console.WriteLine();
            logger.Log(msg, type);
            Console.WriteLine("To log another message, enter L. Otherwise, enter any other key.");
            if (Console.ReadLine() == "L") goto first;
            Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
        }
    }
}
