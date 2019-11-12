using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //Car car1 = new Car();
            //car1.Model = "VW";
            //car1.Regnr = "AB 37 571";

            //Car car2 = new Car();
            //car2.Model = "Skoda";
            //car2.Regnr = "FG 34344";

            Car car1 = Car.Instance;
            car1.Model = "VW";
            car1.Regnr = "AB 37 571";

            Car car2 = Car.Instance;
            Console.WriteLine("Car1 " +  car1.ToString());
            Console.WriteLine("Car2 " + car2.ToString());

            car2.Model = "Skoda";
            Console.WriteLine("Car1 " + car1.ToString());
            Console.WriteLine("Car2 " + car2.ToString());


            Console.ReadLine();
        }
    }
}
