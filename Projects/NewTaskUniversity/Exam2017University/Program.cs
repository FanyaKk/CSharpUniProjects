using System;
using System.Collections.Generic;

namespace zad17_2
{
    struct Slujiteli
    {
        public string name;
        public string EGN;
        public string name_lat;
        public string country;
        public string pk;
        public string town;
    }
    class Program
    {
        static void Main()
        {
            var list = new List<Slujiteli>();
            for (var i = 0; i < 50; i++)
            {
                var slujitel = new Slujiteli();
                Console.WriteLine("Информация за служител № " + (list.Count + 1));
                Console.Write("Въведете име: ");
                slujitel.name = Console.ReadLine();
                Console.Write("EGN: ");
                slujitel.EGN = Console.ReadLine();
                Console.Write("Име на латиница: ");
                slujitel.name_lat = Console.ReadLine();
                Console.Write("Държава: ");
                slujitel.country = Console.ReadLine();
                Console.Write("Пощенски код: ");
                slujitel.pk = Console.ReadLine();
                Console.Write("Град: ");
                slujitel.town = Console.ReadLine();
                list.Add(slujitel);

                Console.Write("Има ли още служители ? ");
                string answer = Console.ReadLine().ToLower();
                if (answer == "не" || answer == "ne")
                {
                    break;
                }
            }

            list.Sort((x, y) =>
            {
                var ret = string.Compare(x.country, y.country);
                if (ret == 0) ret = string.Compare(x.name, y.name);
                return ret;
            });

            for (var i = 0; i < list.Count; i++)
            {
                Console.Write(list[i].name + ", ");
                Console.Write(list[i].EGN + ", ");
                Console.Write(list[i].name_lat + ", ");
                Console.Write(list[i].country + ", ");
                Console.Write(list[i].pk + ", ");
                Console.WriteLine(list[i].town);
            }

            var list1 = new List<Slujiteli>();
            for (var i = 0; i < list.Count; i++)
            {
                if (string.IsNullOrEmpty(list[i].name) || string.IsNullOrEmpty(list[i].EGN) || string.IsNullOrEmpty(list[i].name_lat))
                    list1.Add(list[i]);
            }

            list1.Sort((x, y) => string.Compare(x.EGN, y.EGN));

            for (var i = 0; i < list1.Count; i++)
            {
                Console.Write(list1[i].name + ", ");
                Console.Write(list1[i].EGN + ", ");
                Console.Write(list1[i].name_lat + ", ");
                Console.Write(list1[i].country + ", ");
                Console.Write(list1[i].pk + ", ");
                Console.WriteLine(list1[i].town);
            }

            for (var i = 0; i < list.Count; i++)
            {
                if (!string.IsNullOrEmpty(list[i].name_lat))
                {
                    var names = list[i].name_lat.Split(' ');
                    if (names.Length == 2)
                        Console.WriteLine("{0}_{1}@nncomputers.com", names[1], names[0]);
                    else if (names.Length == 3)
                        Console.WriteLine("{0}_{1}_{2}@nncomputers.com", names[2], names[0], names[2][0]);
                    else
                        Console.WriteLine("{0}@nncomputers.com", list[i].name_lat);
                }
            }
        }
    }
}