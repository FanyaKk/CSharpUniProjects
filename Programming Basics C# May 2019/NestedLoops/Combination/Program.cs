using System;

namespace Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int x1 = 0;
            int x2 = 0;
            int x3 = 0;
            int x4 = 0;
            int x5 = 0;


            int combination = 0;

            //for (x5 = 0; x5 <= number; x5++)
            //{
            //    equation = x1 + x2 + x3 + x4 + x5;

            //    if (equation == number)
            //    {
            //        combination++;
            //    }
            //    for (x4 = 0; x4 <= number; x4++)
            //    {
            //        equation = x1 + x2 + x3 + x4 + x5;

            //        if (equation == number)
            //        {
            //            combination++;
            //        }
            //        for (x3 = 0; x3 <= number; x3++)
            //        {
            //            equation = x1 + x2 + x3 + x4 + x5;

            //            if (equation == number)
            //            {
            //                combination++;
            //            }
            //            for (x2 = 0; x2 <= number; x2++)
            //            {
            //                equation = x1 + x2 + x3 + x4 + x5;

            //                if (equation == number)
            //                {
            //                    combination++;
            //                }
            //                for (x1 = 0; x1 <= number; x1++)
            //                {
            //                    equation = x1 + x2 + x3 + x4 + x5;

            //                    if (equation == number)
            //                    {
            //                        combination++;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(combination);
            for (x5 = 0; x5 <= number; x5++)
            {
                for (x4 = 0; x4 <= number; x4++)
                {
                    for (x3 = 0; x3 <= number; x3++)
                    {
                        for (x2 = 0; x2 <= number; x2++)
                        {
                            for (x1 = 0; x1 <= number; x1++)
                            {
                                int equation = x1 + x2 + x3 + x4 + x5;

                                if (equation == number)
                                {
                                    combination++;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(combination);
        }
    }
}
