using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Gallery
    {
        public static int _id;
        public int Id;
        public string Name { get; set; }

        public Gallery()
        {
            _id++;
            Id = _id;
        }

        Car[] Cars = new Car[0] {};

        public void AddCar(Car car)
        {
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = car;
        }

        public void ShowAllCars()
        {
            if(Cars.Length > 0)
            {
                foreach (Car car in GetAllCars())
                {
                    Console.WriteLine($"{car.Id} {car.Name} {car.Speed} {car.CarCode}");
                }
            }
            else
            {
                Console.WriteLine("Masin yoxdur!");
            }
        }

        public Car[] GetAllCars()
        {
            return Cars;
        }

        
        public Car FindCarById(int id)
        {
            if(Cars.Length > 0)
            {
                foreach (Car car in Cars)
                {
                    if (car.Id == id)
                    {
                        return car;
                    }
                }
            }
            
            return null;
        }

        public Car FindCarByCarCode(string carCode)
        {
            if(Cars.Length > 0)
            {
                foreach (Car car in Cars)
                {
                    if (car.CarCode == carCode)
                    {
                        return car;
                    }
                }
            }
            

            return null;
        }

        public Car[] FindCarsBySpeedInterval(double minSpeed, double maxSpeed)
        {
            Car[] filteredCars = new Car[] { };
            bool f = false;
            if(Cars.Length > 0)
            {
                foreach (Car car in Cars)
                {
                    if (car.Speed > minSpeed && car.Speed < maxSpeed)
                    {
                        f = true;
                        Array.Resize(ref filteredCars, filteredCars.Length + 1);
                        filteredCars[filteredCars.Length - 1] = car;
                    }
                }

                if(f == false)
                {
                    Console.WriteLine($"{minSpeed} {maxSpeed} suret araliginda masin yoxdur!");
                }
            }
            else
            {
                Console.WriteLine("Masin yoxdur!");
            }
            return filteredCars;
        }
    }
}
