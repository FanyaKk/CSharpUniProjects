using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)             //version 2.0
        {
            SortedDictionary<string, List<string>> companies = new SortedDictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] input = command.Split(" -> ");

                string company = input[0];
                string employeeID = input[1];

                if (!companies.ContainsKey(company))
                {
                    companies[company] = new List<string>();
                }
                companies[company].Add(employeeID);

                command = Console.ReadLine();
            }

            foreach (var employee in companies)
            {
                Console.WriteLine(employee.Key);
                Console.WriteLine($"-- {string.Join("\n-- ", employee.Value.Distinct().ToList())}"); // Distinct method removes duplicate elements in a list
            }
        }
        //static void Main(string[] args)               // version 1.0
        //{
        //    SortedDictionary<string, List<string>> companyUsers = new SortedDictionary<string, List<string>>();

        //    string command = "";

        //    while ((command = Console.ReadLine()) != "End")
        //    {
        //        string[] input = command.Split(" -> ").ToArray();
        //        string companyName = input[0];
        //        string employeeId = input[1];
                
        //        if (!companyUsers.ContainsKey(companyName))
        //        {
        //            companyUsers.Add(companyName, new List<string>());
        //        }
        //        //if (!companyUsers[companyName].Contains(employeeId))
        //        //{
        //        //    companyUsers[companyName].Add(employeeId);
        //        //}
        //        companyUsers[companyName].Add(employeeId);
        //    }
        //    foreach (var employee in companyUsers)
        //    {
        //        List<string> distinct = employee.Value.Distinct().ToList();
        //        Console.WriteLine($"{employee.Key}");
        //        Console.WriteLine($"-- {string.Join("\n-- ", distinct)}");
        //        //Console.WriteLine($"-- {string.Join("\n-- ", employee.Value)}");
        //    }
        //}
    }
}
//8. Company Users
//
//Write a program that keeps information about companies and their employees.
//You will be receiving a company name and an employee's id, until you receive the command "End" command. Add
//each employee to the given company.Keep in mind that a company cannot have two employees with the same id.
//When you finish reading the data, order the companies by the name in ascending order.
//Print the company name and each employee's id in the following format:
//{companyName}
//-- {id1}
//-- {id2}
//-- {idN}
//Input / Constraints
// Until you receive the "End" command, you will be receiving input in the format: "{companyName} -> {employeeId}".
// The input always will be valid.
//Examples

//Input                                     Output
//---------------------------------------------------------
//SoftUni -> AA12345                        HP
//SoftUni -> BB12345                        -- BB12345
//Microsoft -> CC12345                      Microsoft
//HP -> BB12345                             -- CC12345
//End                                       SoftUni
//                                          -- AA12345
//                                          -- BB12345
//---------------------------------------------------------
//SoftUni -> AA12345                        Lenovo
//SoftUni -> CC12344                        -- XX23456
//Lenovo -> XX23456                         Movement
//SoftUni -> AA12345                        -- DD11111
//Movement -> DD11111                       SoftUni
//End                                       -- AA12345
//                                          -- CC12344
//