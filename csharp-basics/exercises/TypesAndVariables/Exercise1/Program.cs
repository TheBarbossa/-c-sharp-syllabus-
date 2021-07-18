using System;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars, drivers, passengers, carsDriven, carsNotDriven, seatsInACar;
            double carpoolCapacity, averagePassengersPerCar;

            cars = 100; //cars
            seatsInACar = 4; //seats in a car without drivers seat
            drivers = 28; // drivers
            passengers = 90; // passengers
            carsNotDriven = cars - drivers;  // free cars
            carsDriven = drivers; // cars driven at the moment
            carpoolCapacity = carsDriven * seatsInACar; // carpool capacity
            averagePassengersPerCar = Math.Round((carpoolCapacity / passengers), 2);// average passengers per car

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + averagePassengersPerCar + " in each car.");
            Console.ReadKey();
        }
    }
}