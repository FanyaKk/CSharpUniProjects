using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companyUsers = new SortedDictionary<string, List<string>>();

            string command = "";

            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split(" -> ").ToArray();
                string companyName = input[0];
                string employeeId = input[1];
                
                if (!companyUsers.ContainsKey(companyName))
                {
                    companyUsers.Add(companyName, new List<string>());
                }
                //if (!companyUsers[companyName].Contains(employeeId))
                //{
                //    companyUsers[companyName].Add(employeeId);
                //}
                companyUsers[companyName].Add(employeeId);
            }
            foreach (var employee in companyUsers)
            {
                List<string> distinct = employee.Value.Distinct().ToList();
                Console.WriteLine($"{employee.Key}");
                Console.WriteLine($"-- {string.Join("\n-- ", distinct)}");
                //Console.WriteLine($"-- {string.Join("\n-- ", employee.Value)}");
            }
        }
    }
}
