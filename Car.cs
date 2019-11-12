using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTest
{
    public class Car
    {
        //static instance til at refere til objektet
        private static Car _instance = new Car(); //Eager initialization

        //Static property til at tilgå objektet
        public static Car Instance
        {
            get
            {   // Lazy initialization
                //if (_instance == null)
                //{
                //    _instance = new Car();
                //}
                return _instance;
            }
           
        }

        public string Model { get; set; }
        public string Regnr { get; set; }


        //Constructor er private
        private Car()
        {
        }

        public override string ToString()
        {
            return Model + " " + Regnr;
        }
    }
}
