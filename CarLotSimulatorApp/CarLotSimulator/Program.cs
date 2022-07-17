using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            var myLot = new CarLot();

            //DONE - Create a seperate class file called Car
            //DONE - Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE - Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE - The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var firstCar = new Car();
            firstCar.Year = 1969;
            firstCar.Make = "Chevrolet";
            firstCar.Model = "Camaro";
            firstCar.EngineNoise = "grrrr";
            firstCar.HonkNoise = "Ayo move";
            firstCar.IsDriveable = true;

            myLot.Cars.Add(firstCar);
            Console.WriteLine($"There are {CarLot.numberOfCars} cars in the lot");

            var secondCar = new Car(1970, "Dodge", "Charger", "vroom", "%D$G%DF@", false);

            myLot.Cars.Add(secondCar);
            Console.WriteLine($"There are {CarLot.numberOfCars} cars in the lot");

            var thirdCar = new Car()
            {
                Year = 1993,
                Make = "Toyota",
                Model = "Supra",
                EngineNoise = "floom",
                HonkNoise = "beep beep",
                IsDriveable = false
            };

            myLot.Cars.Add(thirdCar);
            Console.WriteLine($"There are {CarLot.numberOfCars} cars in the lot");

            firstCar.MakeEngineNoise(firstCar.EngineNoise);
            secondCar.MakeEngineNoise(secondCar.EngineNoise);
            thirdCar.MakeEngineNoise(thirdCar.EngineNoise);

            firstCar.MakeHonkNoise(firstCar.HonkNoise);
            secondCar.MakeHonkNoise(secondCar.HonkNoise);
            thirdCar.MakeEngineNoise(thirdCar.HonkNoise);

            //*************BONUS*************//

            // DONE - Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            // DONE - Create a CarLot class
            // DONE - It should have at least one property: a List of cars
            // DONE - Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            // DONE - At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (var vehicle in myLot.Cars)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
            }
        }
    }
}
