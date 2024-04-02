using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Car
    {
        private static int _id;
        public int Id;
        public string Name { get; set; }
        public double Speed { get; set; }
        private static int _carCode = 1000;
        public string CarCode { get; set; }

        public Car(string name,  double speed, string carCode)
        {
            Name = name;
            Speed = speed;            
            _id++;
            Id = _id;

            CarCode = carCode;
            //_carCode = 1000;
            _carCode++;
            CarCode += _carCode;

            
           
            
           

            

        }

        public void ShowCar()
        {
            Console.WriteLine($"{Id}, {Name}, {Speed}, {CarCode}");
        }

    }
}
