using introOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static introOOP.Kroon;

namespace introToOOP
{
    internal class Train : Vehicle
    {
        private int[] _cars=new int[10];
        private readonly string _id;
        private int _currentSpeed = 0;
        private int _maxSpeed;
        
        public int[] Cars { get { return _cars; } set { _cars = value; } }
        public string Id { get { return _id; } set { _id = value; } }
        public int CurrentSpeed { get { return _currentSpeed; } set { _currentSpeed = value; } }
        public int MaxSpeed { get { return _maxSpeed; } set { _maxSpeed = value; } }


        public Train(int[] cars, string id, int maxSpeed, int yearOfManufacture, string color, string manufacturer)
           : base(yearOfManufacture, color, manufacturer)
        {
            _id = id;
            MaxSpeed = maxSpeed;
            
            Cars = cars;
        }
        public void Removecar(int carNUM = 2)
        {
            for (int i = 0; i < _cars.Length; i++)
            {
                _cars[carNUM] = 0;
            }
            _cars[^1] = _cars[carNUM];
             

        }

        public Train(string id, int maxSpeed, int year, string color, string manufacturer)
            : this(id, new TrainCar[5], maxSpeed, year, color, manufacturer)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                Cars[i] = new TrainCar(50, i);
            }
        }

        //public void AddCar(int numberOfPassengers)
        //{
        //    for (int i = 0; i < _cars.Length; i++)
        //    {
        //        if (_cars[i] == 0)
        //        {
        //            _cars[i] = numberOfPassengers;
        //            return;
        //        }
        //    }
        //    int[] newCars = new int[_cars.Length + 1];
        //    Array.Copy(_cars, newCars, _cars.Length);
        //    newCars[^1] = numberOfPassengers;
        //    _cars = newCars;
        //}

        //another solution
        public void AddCar(int numberOfPassengers)
        {
            int emptyCar = Array.IndexOf(_cars, 0);
            if (emptyCar == -1)
            {
                int[] newCars = new int[_cars.Length + 1];
                Array.Copy(_cars, newCars, _cars.Length);
                newCars[^1] = numberOfPassengers;
                _cars = newCars;
                return;
            }
            _cars[emptyCar] = numberOfPassengers;
        }

        public void Speed()
        {

            if(_currentSpeed <= MaxSpeed)
            {
                _currentSpeed +=10;
            }
        }
        public void Slow()
        {

        }
        public override string ToString()
        {
            string str = "";
            foreach (PropertyInfo item in GetType().GetProperties())
            {
                if (item.Name != "Cars")
                    str += $"{item.Name} : {item.GetValue(this)} \n";
            }

            for (int i = 0; i < _cars.Length; i++)
            {
                if (_cars[i] != 0)
                    str += $"Car {i} Pssengers: {_cars[i]}\n";
            }

            return str;


        }

        public int this[int i]
        {
            get 
            {
            return _cars[i];

            }
            set {
               
                if (value < 0) {
                    throw new ArgumentException("The number of seats must be positive");
                }
                else
                _cars[i] = value;
            }
        }
    }
}