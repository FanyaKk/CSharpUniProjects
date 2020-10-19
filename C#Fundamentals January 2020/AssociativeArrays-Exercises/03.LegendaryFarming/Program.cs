using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string material = "";
            int quantity = 0;
            bool hasLegendaryItem = false;
            string legendaryItem = "";

            Dictionary<string, int> materialKey = new Dictionary<string, int>();
            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();

            materialKey["shards"] = 0;
            materialKey["fragments"] = 0;
            materialKey["motes"] = 0;

            while (hasLegendaryItem == false)
            {
                string[] input = Console.ReadLine()
                    .ToLower()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 0; i < input.Length; i+=2)
                {
                    material = input[i + 1];
                    quantity = int.Parse(input[i]);

                    if (materialKey.ContainsKey(material))//material == "shades" || material == "fragments" || material == "motes")
                    {
                        materialKey[material] += quantity;
                        if (materialKey[material] >= 250)
                        {
                            materialKey[material] -= 250;
                            if (material == "shards")
                            {
                                legendaryItem = "Shadowmourne";
                            }
                            else if (material == "fragments")
                            {
                                legendaryItem = "Valanyr";
                            }
                            else if (material == "motes")
                            {
                                legendaryItem = "Dragonwrath";
                            }
                            hasLegendaryItem = true;
                            break;
                        }
                    }
                    else
                    {
                        if(!junk.ContainsKey(material))
                        {
                            junk[material] = 0;
                        }
                        junk[material] += quantity;
                    }
                }
            }
            Console.WriteLine($"{legendaryItem} obtained!");
            materialKey = materialKey
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var item in materialKey)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
