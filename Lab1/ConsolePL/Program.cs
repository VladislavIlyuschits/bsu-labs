using System;

namespace ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = new StudentsAction.Concrete.StudentsAction();

            Console.WriteLine("All Data:\n");
            Console.WriteLine(group.GetGroupsData);

            while (true)
            {
                System.Console.WriteLine("\n");
                System.Console.WriteLine("Select your choice:");
                System.Console.WriteLine("1:Get student average mark");
                System.Console.WriteLine("2:Get group average mark");

                var key = System.Console.ReadKey();

                if (key.Key == ConsoleKey.D1)
                {
                    System.Console.WriteLine("\n Enter student name (in any register):");
                    var name = System.Console.ReadLine();
                    Console.WriteLine($"\t{group.GetStudentAverageMark(name)}");
                    continue;
                }

                if (key.Key == ConsoleKey.D2)
                {
                    System.Console.WriteLine("\n Enter group name (in any register):");
                    var name = System.Console.ReadLine();
                    Console.WriteLine($"\t{group.GetGropAverageMark(name)}");
                }
            }
        }
    }
}
