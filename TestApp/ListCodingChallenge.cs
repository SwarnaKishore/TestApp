using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class ListCodingChallenge
    {

        public void listSort()
        {
            var cars = new List<Car>() { new Car() { Id = 1, Make = "Toyota" }, new Car { Id = 2, Make = "Chevy" } };
            var trucks = new List<Truck>() { new Truck() { Id = 3, Make = "Dodge" }, new Truck { Id = 4, Make = "Ford" } };

            var vehicles = new List<Vehicle>();
            foreach (var car in cars)
            {
                vehicles.Add(new Vehicle { Id = car.Id, Make = car.Make });
            }

            foreach (var truck in trucks)
            {
                vehicles.Add(new Vehicle { Id = truck.Id, Make = truck.Make });
            }

            var sortedVehicles = vehicles.OrderBy(a => a.Make);
            foreach (var vehicle in sortedVehicles)
            {
                Console.WriteLine(vehicle.Make + " " + vehicle.Id);
            }

            // Sort both lists by the Make property and display the results.
            // The expected output should be:
            //   Chevy 2
            //   Dodge 3
            //   Ford 4
            //   Toyota 1
        }

    }

    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
    }

    public class Truck
    {
        public int Id { get; set; }
        public string Make { get; set; }
    }

    public class Vehicle
    {

        public int Id { get; set; }
        public string Make { get; set; }
    }
}

