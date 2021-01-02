using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)             //version 2.0
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            Dictionary<string, string> carRegister = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split();

                string command = input[0];
                string username = input[1];
                if(command == "register")
                {
                    string plateNumber = input[2];
                    if (!carRegister.ContainsKey(username))
                    {
                        carRegister[username] = plateNumber;
                        Console.WriteLine($"{username} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }

                }
                else if (command == "unregister")
                {
                    if (carRegister.ContainsKey(username))
                    {
                        carRegister.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, carRegister.Select(c=> $"{c.Key} => {c.Value}")));
        }
        //static void Main(string[] args)                   //version 1.0
        //{
        //    Dictionary<string, string> regUsers = new Dictionary<string, string>();

        //    int n = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < n; i++)
        //    {
        //        string[] command = Console.ReadLine().Split().ToArray();

        //        string username = command[1];
                
        //        if (command[0] == "register")
        //        {
        //            string license = command[2];
        //            if (!regUsers.ContainsKey(username))
        //            {
        //                regUsers[username] = license;
        //                Console.WriteLine($"{username} registered {license} successfully");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"ERROR: already registered with plate number {license}");
        //            }
        //        }
        //        else if (command[0] == "unregister")
        //        {
        //            if (regUsers.ContainsKey(username))
        //            {
        //                Console.WriteLine($"{username} unregistered successfully");
        //                regUsers.Remove(username);
        //            }
        //            else
        //            {
        //                Console.WriteLine($"ERROR: user {username} not found");
        //            }
        //        }
        //    }
        //    foreach (var user in regUsers)
        //    {
        //        Console.WriteLine($"{user.Key} => {user.Value}");
        //    }
        //}
    }
}
//5. SoftUni Parking

//SoftUni just got a new parking lot. It’s so fancy, it even has online parking validation. Except the online service
//doesn’t work. It can only receive users’ data, but it doesn’t know what to do with it. Good thing you’re on the dev
//team and know how to fix it, right?
//Write a program, which validates a parking place for an online service.Users can register to park and unregister to
//leave.
//The program receives 2 commands:

// "register {username} {licensePlateNumber}":
//  o The system only supports one car per user at the moment, so if a user tries to register another
//license plate, using the same username, the system should print:
//"ERROR: already registered with plate number {licensePlateNumber}"
//  o If the aforementioned checks passes successfully, the plate can be registered, so the system should
//print:
//"{username} registered {licensePlateNumber} successfully"

// "unregister {username}":

//  o If the user is not present in the database, the system should print:
//"ERROR: user {username} not found"
//  o If the aforementioned check passes successfully, the system should print:
//"{username} unregistered successfully"

//After you execute all of the commands, print all the currently registered users and their license plates in the format:
// "{username} => {licensePlateNumber}";
//Input
// First line: n - number of commands – integer
// Next n lines: commands in one of the two possible formats:
//  o Register: "register {username} {licensePlateNumber}"
//  o Unregister: "unregister {username}"

//The input will always be valid and you do not need to check it explicitly.
//Examples

//Input                                         Output

//5                                             John registered CS1234JS successfully
//register John CS1234JS                        George registered JAVA123S successfully
//register George JAVA123S                      Andy registered AB4142CD successfully
//register Andy AB4142CD                        Jesica registered VR1223EE successfully
//register Jesica VR1223EE                      Andy unregistered successfully
//unregister Andy                               John => CS1234JS
//                                              George => JAVA123S
//                                              Jesica => VR1223EE
//
//4
//register Jony AA4132BB                        Jony registered AA4132BB successfully
//register Jony AA4132BB                        ERROR: already registered with plate number AA4132BB
//register Linda AA9999BB                       Linda registered AA9999BB successfully
//unregister Jony                               Jony unregistered successfully
//                                              Linda => AA9999BB
//
//6
//register Jacob MM1111XX                       Jacob registered MM1111XX successfully
//register Anthony AB1111XX                     Anthony registered AB1111XX successfully
//unregister Jacob                              Jacob unregistered successfully
//register Joshua DD1111XX                      Joshua registered DD1111XX successfully
//unregister Lily                               ERROR: user Lily not found
//register Samantha AA9999BB                    Samantha registered AA9999BB successfully
//                                              Joshua => DD1111XX
//                                              Anthony => AB1111XX
//                                              Samantha => AA9999BB