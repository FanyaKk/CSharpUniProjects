using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)             //version 2.0
        {
            int quantity = 0;
            string material = string.Empty;
            bool hasLegendaryItem = false;
            string legendaryItemName = string.Empty;

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();

            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;

            while (!hasLegendaryItem)
            {
                string[] input = Console.ReadLine().ToLower().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    quantity = int.Parse(input[i]);
                    material = input[i + 1];

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;
                            if (material == "shards")
                            {
                                legendaryItemName = "Shadowmourne";
                            }
                            else if (material == "fragments")
                            {
                                legendaryItemName = "Valanyr";
                            }
                            else if (material == "motes")
                            {
                                legendaryItemName = "Dragonwrath";
                            }

                            hasLegendaryItem = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk[material] = 0;
                        }
                        junk[material] += quantity;
                    }    
                }
            }
            
            keyMaterials = keyMaterials.OrderByDescending(k => k.Value).ThenBy(k => k.Key).ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine($"{legendaryItemName} obtained!");
            Console.WriteLine(string.Join(Environment.NewLine, keyMaterials.Select(k=>$"{k.Key}: {k.Value}")));
            Console.WriteLine(string.Join(Environment.NewLine, junk.Select(j=>$"{j.Key}: {j.Value}")));

        }
        //static void Main(string[] args)               //version1.0
        //{
        //    string material = "";
        //    int quantity = 0;
        //    bool hasLegendaryItem = false;
        //    string legendaryItem = "";

        //    Dictionary<string, int> materialKey = new Dictionary<string, int>();
        //    SortedDictionary<string, int> junk = new SortedDictionary<string, int>();

        //    materialKey["shards"] = 0;
        //    materialKey["fragments"] = 0;
        //    materialKey["motes"] = 0;

        //    while (hasLegendaryItem == false)
        //    {
        //        string[] input = Console.ReadLine()
        //            .ToLower()
        //            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        //            .ToArray();

        //        for (int i = 0; i < input.Length; i+=2)
        //        {
        //            material = input[i + 1];
        //            quantity = int.Parse(input[i]);

        //            if (materialKey.ContainsKey(material))   //material == "shades" || material == "fragments" || material == "motes")
        //            {
        //                materialKey[material] += quantity;
        //                if (materialKey[material] >= 250)
        //                {
        //                    materialKey[material] -= 250;
        //                    if (material == "shards")
        //                    {
        //                        legendaryItem = "Shadowmourne";
        //                    }
        //                    else if (material == "fragments")
        //                    {
        //                        legendaryItem = "Valanyr";
        //                    }
        //                    else if (material == "motes")
        //                    {
        //                        legendaryItem = "Dragonwrath";
        //                    }
        //                    hasLegendaryItem = true;
        //                    break;
        //                }
        //            }
        //            else
        //            {
        //                if(!junk.ContainsKey(material))
        //                {
        //                    junk[material] = 0;
        //                }
        //                junk[material] += quantity;
        //            }
        //        }
        //    }
        //    Console.WriteLine($"{legendaryItem} obtained!");
        //    materialKey = materialKey
        //        .OrderByDescending(kvp => kvp.Value)
        //        .ThenBy(kvp => kvp.Key)
        //        .ToDictionary(a => a.Key, b => b.Value);

        //    foreach (var item in materialKey)
        //    {
        //        Console.WriteLine($"{item.Key}: {item.Value}");
        //    }
        //    foreach (var item in junk)
        //    {
        //        Console.WriteLine($"{item.Key}: {item.Value}");
        //    }
        //}
    }
}
//3. Legendary Farming

//You’ve done all the work and the last thing left to accomplish is to own a legendary item.However, it’s a tedious
//process and it requires quite a bit of farming.Anyway, you are not too pretentious - any legendary item will do. The
//possible items are:

// Shadowmourne - requires 250 Shards;
// Valanyr - requires 250 Fragments;
// Dragonwrath - requires 250 Motes;

//Shards, Fragments and Motes are the key materials and everything else is junk.You will be given lines of input, in
//the format:
//2 motes 3 ores 15 stones
//Keep track of the key materials - the first one that reaches the 250 mark, wins the race.At that point you have to
//print that the corresponding legendary item is obtained.Then, print the remaining shards, fragments, motes,
//ordered by quantity in descending order, then by name in ascending order, each on a new line.Finally, print the
//collected junk items in alphabetical order.

//Input
// Each line comes in the following format: { quantity} {material} {quantity} {material} … {quantity} {material}
//Output
// On the first line, print the obtained item in the format: {Legendary item} obtained!
// On the next three lines, print the remaining key materials in descending order by quantity
//o If two key materials have the same quantity, print them in alphabetical order
// On the final several lines, print the junk items in alphabetical order
//o All materials are printed in format {material}: {quantity}
//o The output should be lowercase, except for the first letter of the legendary

//Examples

//Input                                     Output
//3 Motes 5 stones 5 Shards                 Valanyr obtained!
//6 leathers 255 fragments 7 Shards         fragments: 5
//                                          shards: 5
//                                          motes: 3
//                                          leathers: 6
//                                          stones: 5
//---------------------------------------------------------------------------
//123 silver 6 shards 8 shards 5 motes      Dragonwrath obtained!
//9 fangs 75 motes 103 MOTES 8 Shards       shards: 22
//86 Motes 7 stones 19 silver               motes: 19
//                                          fragments: 0
//                                          fangs: 9
//                                          silver: 123
