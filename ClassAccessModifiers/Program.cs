using Core.Models;

namespace ClassAccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            string name;
            double speed;
            string carCode;
            string newCarCode = "";
            string ChangeNumber = "";
            int id;
            double minSpeed;
            double maxSpeed;

            Gallery gallery = new Gallery();

            do
            {
                Console.WriteLine("1.Masin elave edin");
                Console.WriteLine("2.Butun masinlara baxin");
                Console.WriteLine("3.Masin axtaris edin");
                Console.WriteLine("0.Programi bitirin");

                Console.Write("Secim edin: ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Masinin adini daxil edin: ");
                    name = Console.ReadLine();

                    do
                    {
                        Console.Write("Masinin suretini daxil edin: ");
                    }
                    while (!double.TryParse(Console.ReadLine(), out speed));

                    do
                    {
                        Console.Write("Masinin CarCode'nu daxil edin: ");
                        carCode = Console.ReadLine();
                    } while (!(carCode.Length == 2 && carCode == carCode.ToUpper() && (char.IsLetter(carCode[0]) && char.IsLetter(carCode[1]))));


                    Car car = new Car(name, speed, carCode);

                    gallery.AddCar(car); 

                    //newCarCode = "";

                }

                else if (choice == "2")
                {
                    gallery.ShowAllCars();
                }

                else if (choice == "3")
                {
                    do
                    {
                        Console.WriteLine("1.Id'e gore axtaris edin");
                        Console.WriteLine("2.Carcode'a gore axtaris edin");
                        Console.WriteLine("3.Surete gore axtaris edin");
                        Console.WriteLine("4.Axtaris etmekden imtina edin");

                        Console.Write("Secim edin: ");
                        choice = Console.ReadLine();

                        if (choice == "1")
                        {
                            do
                            {
                                Console.Write("Axtarmaq istediyiniz id'ni daxil edin: ");
                            }
                            while (!int.TryParse(Console.ReadLine(), out id));

                            if(gallery.FindCarById(id) == null)
                            {
                                Console.WriteLine("Masin yoxdur!");
                            }
                            else
                            {
                                gallery.FindCarById(id).ShowCar();
                            }
                        }
                        else if (choice == "2")
                        {
                            Console.Write("Axtarmaq istediyiniz CarCode daxil edin: ");
                            carCode = Console.ReadLine();

                            if(gallery.FindCarByCarCode(carCode) == null) 
                            {
                                Console.WriteLine("Masin yoxdur!");
                            }
                            else
                            {
                                gallery.FindCarByCarCode(carCode).ShowCar();
                            }
                        }

                        else if (choice == "3")
                        {
                            do
                            {
                                Console.Write("MinSpeed sureti daxil edin: ");
                            }
                            while (!double.TryParse(Console.ReadLine(), out minSpeed));

                            do
                            {
                                Console.Write("MaxSpeed sureti daxil edin: ");
                            }
                            while (!double.TryParse(Console.ReadLine(), out maxSpeed));

                            foreach (Car item in gallery.FindCarsBySpeedInterval(minSpeed, maxSpeed))
                            {
                                item.ShowCar();
                            }
                        }
                    }
                    while (choice != "4");
                }
            }
            while (choice != "0");

        }
    }
}