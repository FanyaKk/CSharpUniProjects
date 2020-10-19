using System;

namespace _02.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int periodInDays = int.Parse(Console.ReadLine());

            int untreatedPatients = 0;
            int treatedPatients = 0;
            int doctors = 7;
            int totalUntreatedPatients = 0;

            for (int i = 1; i <= periodInDays; i++)
            {
                if (i % 3 == 0)
                {
                    if (totalUntreatedPatients > treatedPatients)
                    {
                        doctors++;
                    }
                }
                int patientsPerDay = int.Parse(Console.ReadLine());

               
                if (patientsPerDay > doctors)
                {
                    untreatedPatients = patientsPerDay - doctors;
                    treatedPatients += doctors;
                    totalUntreatedPatients += untreatedPatients;
                }
                else
                {
                    treatedPatients += patientsPerDay;
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {totalUntreatedPatients}.");
        }
    }
}
