using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_300_F22SD_Labs
{
    public class Vehicle
    {
        private string _licensenumber = "0000000";

        public string LicenseNumber 
        {
            get { return _licensenumber;} 
        }

        private void UpdateLicenseNumber(string licenseNumber)
        {
            if (licenseNumber.Length < 3 || licenseNumber.Length > 7 || !licenseNumber.All(c => Char.IsLetterOrDigit(c))) 
            {
                throw new Exception("License number must be between 3 and 7 alphanumeric characters.");
            }
            else
            {
                _licensenumber = licenseNumber;
            }
        }

        private HashSet<ParkingSpot> _parkingspots = new HashSet<ParkingSpot>();

        /////// CONSTRUCTOR
        public Vehicle(string licensenumber)
        {
            UpdateLicenseNumber(licensenumber);
        }
    }
}
