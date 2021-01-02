using System;
using System.Collections.Generic;

namespace VechicleCatalogue
{
    public class Catalog
    {
        public List<Truck> Trucks { get; set; }
        public  List<Car> Cars { get; set; }

        public Catalog()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }
    }
}
