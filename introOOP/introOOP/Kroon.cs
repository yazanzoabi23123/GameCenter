using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introOOP
{
    internal class Kroon
    {
        internal class TrainCar
        {
            private int _carNumber;
            private int _numberOfSeats;
            public int CarNumber
            {
                get { return _carNumber; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("The car number must be positive");
                    }
                    _carNumber = value;
                }
            }
            public int NumberOfSeats
            {
                get { return _numberOfSeats; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("The number of seats must be positive");
                    }
                    _numberOfSeats = value;
                }
            }

            public TrainCar(int numberOfSeats, int carNumber)
            {
                NumberOfSeats = numberOfSeats;
                CarNumber = carNumber;
            }

            public void Announcment(string text)
            {
                Console.WriteLine(text);
            }


        }

    }
}
