using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introOOP
{
   
    
        internal class Vehicle
        {
        private int _year;
        private string _color;
        private string _manufacturer;


        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }
            set
            {
                _manufacturer = value[0].ToString().ToUpper() + value.Substring(1).ToLower();

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manufecturer can not be empty");
                }
                _manufacturer = value;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Color can not be empty");
                }
                _color = value;
            }
        }


        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 1920 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Year must be between 1920 and " + DateTime.Now.Year);
                }
                _year = value;
            }
        }


        public Vehicle(int year, string color, string manufacturer)
        {
            Year = year;
            Color = color;
            Manufacturer = manufacturer;
        }

        public void Start()
        {
            Console.WriteLine($"The Vehicle {this._manufacturer} is start moving");
        }
        public void Stop()
        {
            Console.WriteLine($"The Vehicle {this._manufacturer} is stop moving");
        }

    }

}
    

