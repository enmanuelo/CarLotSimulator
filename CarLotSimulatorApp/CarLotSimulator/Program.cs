using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

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

            var secondCar = new Car(1970, "Dodge", "Charger", "vroom", "%D$G%DF@", false);

            var thirdCar = new Car()
            {
                Year = 1993,
                Make = "Toyota",
                Model = "Supra",
                EngineNoise = "floom",
                HonkNoise = "beep beep",
                IsDriveable = false
            };

            firstCar.MakeEngineNoise(firstCar.EngineNoise);
            secondCar.MakeEngineNoise(secondCar.EngineNoise);
            thirdCar.MakeEngineNoise(thirdCar.EngineNoise);

            firstCar.MakeHonkNoise(firstCar.HonkNoise);
            secondCar.MakeHonkNoise(secondCar.HonkNoise);
            thirdCar.MakeEngineNoise(thirdCar.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
