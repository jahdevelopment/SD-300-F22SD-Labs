using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_300_F22SD_Labs
{
    public class ParkingSpot
    {
        private int _number;

        private  Vehicle _vehicle;  // What is this for?

        public Vehicle Vehicle
        {
            get { return _vehicle; }
            set { _vehicle = value; }
        }

        private CarPark _carpark;   // What is this for?

        public CarPark CarPark      // What is this for?
        { 
            get { return _carpark; } 
        }

        public void SetCarPark(CarPark carPark)
        {
            _carpark = carPark;
        }

       

        /////// CONSTRUCTORS
    
        public ParkingSpot(int number, CarPark carpark)
        {
            _number = number;

            _carpark = carpark;
        }

        public ParkingSpot(int number)
        {
            _number = number;
        }
    }
}
