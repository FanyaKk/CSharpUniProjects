using System;

namespace CookiesBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            int batch_count = int.Parse(Console.ReadLine());

            for (int current_batch = 1; current_batch <= batch_count; current_batch++)
            {
                bool containsEggs = false;
                bool containsFlour = false;
                bool containsSugar = false;

                string product_name = Console.ReadLine();

                while (true)
                {
                    if (product_name == "eggs")
                    {
                        containsEggs = true;
                    }
                    else if (product_name == "flour")
                    {
                        containsFlour = true;
                    }
                    else if (product_name == "sugar")
                    {
                        containsSugar = true;
                    }
                    else if (product_name == "Bake!")
                    {
                        if (containsEggs && containsFlour && containsSugar)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                        }
                    }
                    product_name = Console.ReadLine();
                }
                Console.WriteLine("Baking batch number : {0}...", current_batch);
            }
        }
    }
}
