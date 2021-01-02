using System;
using System.Collections.Generic;
using System.Linq;

namespace VechicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            //List<Truck> trucks = new List<Truck>();
            //List<Car> cars = new List<Car>();
            string input = Console.ReadLine();
            
            while(input != "end")
            {
                string[] token = input.Split("/").ToArray();

                string type = token[0];
                string brand = token[1];
                string model = token[2];
                
                if (type == "Truck")
                {
                    string weight = token[3];
                    Truck truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    };
                    catalog.Trucks.Add(truck);
                }
                else
                {
                    string horsePower = token[3];
                    Car car = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePower
                    };
                    catalog.Cars.Add(car);
                }
            input = Console.ReadLine();
            }
            //trucks = catalog.Trucks.OrderBy(b=>b.Brand).ToList();
            //cars = catalog.Cars.OrderBy(b=>b.Brand).ToList();

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalog.Cars.OrderBy(b => b.Brand).ToList())
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalog.Trucks.OrderBy(b => b.Brand).ToList())
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}