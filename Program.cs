using SD_300_F22SD_Labs;

ParkingSpot newSpot = new ParkingSpot(6); 

CarPark newPark = new CarPark(10);

Vehicle myCar = new Vehicle("KYD787");

Console.WriteLine(myCar.LicenseNumber);

newPark.AddParkingSpot(newSpot);

Console.WriteLine(newPark.GetParkingSpots().Count);

Console.WriteLine(newSpot.CarPark.GetParkingSpots().Count);

Console.WriteLine(newPark.Capacity);

Console.WriteLine(newSpot.CarPark == newPark);

Console.WriteLine(newPark.GetParkingSpots().First() == newSpot);

