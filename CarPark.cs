﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_300_F22SD_Labs
{
    public class CarPark
    {
        private HashSet<ParkingSpot> _parkingspots = new HashSet<ParkingSpot>(); // why did you make this HashSet here and not inside of ParkingSpot class?

        public void AddParkingSpot(ParkingSpot parkingSpot)
        {
            _parkingspots.Add(parkingSpot);

            parkingSpot.SetCarPark(this);
        }

        public HashSet<ParkingSpot> GetParkingSpots()
        {
            HashSet<ParkingSpot> spotReferenceCopies;

            spotReferenceCopies = _parkingspots.ToHashSet();

            return spotReferenceCopies;
        }

        private int _capacity;

        public int Capacity 
        { 
            get { return _capacity; } 
        }

        private void _setcapacity(int newCapacity)
        {
            if (newCapacity  > 0)
            {
                _capacity = newCapacity;
            }
            else
            {
                throw new Exception("Capacity must exceed 0.");
            }
        }

        private void _initializeemptyspots()
        {
            for (int i = 1; i <= Capacity; i++)
            {
                _parkingspots.Add(new ParkingSpot(i, this));
            }
        }

        private int _spotcount = 1;
        
        //////// CONSTRUCTOR 
        
        public CarPark(int capacity)
        {
            _setcapacity(capacity);
        }
    }
}
