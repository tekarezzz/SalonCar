using System;
using System.Collections;
using System.Collections.Generic;

namespace CarLibrary
{
    public class CarShowroom : IEnumerable<Car>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int CarCount => cars.Count;

        private List<Car> cars;

        public CarShowroom(string name, string address, IEnumerable<Car> carCollection)
        {
            Name = name;
            Address = address;
            cars = new List<Car>();

            var uniqueCars = new HashSet<string>();
            foreach (var car in carCollection)
            {
                if (uniqueCars.Add(car.VIN))
                {
                    cars.Add(car);
                }
            }
        }

        public IEnumerator<Car> GetEnumerator() => cars.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
