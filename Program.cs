using SD_300_F22SD_Labs;

ParkingSpot newSpot = new ParkingSpot(6); // Set the number of spot to assign for parking

CarPark newPark = new CarPark(10); // Set Capacity of the CarPark

Vehicle myCar = new Vehicle("KYD787");

newPark.AddParkingSpot(newSpot);



Console.WriteLine(myCar.LicenseNumber);

Console.WriteLine(newPark.GetParkingSpots().Count);

Console.WriteLine(newSpot.CarPark.GetParkingSpots().Count);

Console.WriteLine(newPark.Capacity);

Console.WriteLine(newSpot.CarPark == newPark);

Console.WriteLine(newPark.GetParkingSpots().First() == newSpot);

