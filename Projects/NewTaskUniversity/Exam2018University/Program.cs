using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Lab2
{
    public class Operations
    {
        public string name = Console.ReadLine();
        DateTime dateTime = DateTime.Now;
        public int operationType = int.Parse(Console.ReadLine());
        public string commenter = Console.ReadLine();
    }
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Operations>();
            
            for (var i = 0; i < 1000; i++)
            {
                var operation = new Operations();
                Console.Write("Please enter an operator name:");
                operation.name = Console.ReadLine();
                Console.Write("Date and time of operation done");
                DateTime dateTime = DateTime.Now;
                Console.Write("Please enter an operation type:");
                operation.operationType = int.Parse(Console.ReadLine());
                Console.Write("Please enter a commenter:");
                operation.commenter = Console.ReadLine();
                list.Add(operation);
                Console.Write("Въвеждане на нов потребител?");
                string action = Console.ReadLine();

            }
            int input = int.Parse(Console.ReadLine());


            while (input != 0)
            {
                Console.WriteLine("Please enter another integer: ");
                input = int.Parse(Console.ReadLine());
            }

            if (input == 0 )
            {
                Console.WriteLine("The number you have entered is: " + " " + input);
                operations.Add(input);
                foreach (int value in operations)
                {
                    Console.WriteLine("The number that was added to the list is : " + " " + value);
                }
                Console.ReadLine();
            }
        }
    }
}

//using System;
//using System.Collections.Generic;

//namespace Exam2018University
//{
//    public class Operations
//    {
//        public string name;
//        public int operationType;
//        public string comenter;
//        public string action;

//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var list = new List<Operations>();
//            //int list = 0;

//            DateTime dateTime = DateTime.Now;

//            for (int i = 0; i < 1000; i++)
//            {
//                var operation = new Operations();
//            }

//            while (list < 1000)
//            {
//                if (operationType == 1)
//                {
//                    //Console.WriteLine($"{dateTime}; {name}; нови данни; {comenter}");
//                    foreach(string operation in operations)
//                    {

//                    }
//                    list++;
//                    Console.Write("Въвеждане на нов потребител?");
//                }
//                else if (operationType == 2)
//                {
//                    Console.WriteLine($"{dateTime}; {name}; промяна на данни; {comenter}");
//                }
//                else if (operationType == 3)
//                {
//                    Console.WriteLine($"{dateTime}; {name}; изтриване на данни; {comenter}");
//                }
//                else if (operationType == 4)
//                {
//                    Console.WriteLine($"{dateTime}; {name}; справка с лични данни; {comenter}");
//                }
//            }
//        }
//    }
//}
