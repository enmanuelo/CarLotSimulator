using System;
namespace CarLotSimulator
{
	public class Car
	{
		public Car()
		{
			CarLot.numberOfCars++;
		}

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
			Year = year;
			Make = make;
			Model = model;
			EngineNoise = engineNoise;
			HonkNoise = honkNoise;
			IsDriveable = isDriveable;

			CarLot.numberOfCars++;
		}

		//Properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
		public int Year { get; set; }
		public String Make { get; set; }
		public String Model { get; set; }
		public String EngineNoise { get; set; }
		public String HonkNoise { get; set; }
		public bool IsDriveable { get; set; }

		public void MakeEngineNoise(string engineNoise)
		{
            //EngineNoise = engineNoise;
            Console.WriteLine(engineNoise);
		}

		public void MakeHonkNoise(string honkNoise)
		{
            //HonkNoise = honkNoise;
            Console.WriteLine(honkNoise);
		}
	}
}

