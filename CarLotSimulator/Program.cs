using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property            

            var newCarLot = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars


            var newCar1 = new Car() { Year = 1978, Make = "Ford", Model = "F150", EngineNoise = "Chuga Chuga", HonkNoise = "Hooonk", IsDrivable = true };
            var newCar2 = new Car() { Year = 2005, Make = "Chevy", Model = "Camaro", EngineNoise = "Vroom Vroom", HonkNoise = "Ahhooga", IsDrivable = false };
            var newCar3 = new Car() { Year = 1997, Make = "Toyota", Model = "Tacoma", EngineNoise = "vrr vrr", HonkNoise = "Hink Hink", IsDrivable = true };

            newCarLot.LotList.Add(newCar1);
            newCarLot.LotList.Add(newCar2);
            newCarLot.LotList.Add(newCar3);

            //Set the properties for each of the cars

            //Year, Make, Model, EngineNoise, HonkNoise, IsDriveable



            //newCar1.Year = 1978;
            //newCar2.Year = 2002;
            //newCar3.Year = 2020;

            //newCar1.Make = "Ford";
            //newCar2.Make = "Chevy";
            //newCar3.Make = "Nissan";

            //newCar1.Model = "F150";
            //newCar2.Model = "Trans Am";
            //newCar3.Model = "Sentra";

            //newCar1.EngineNoise = "chugga chugga";
            //newCar2.EngineNoise = "vroom vroom";
            //newCar3.EngineNoise = "ticky tacky";

            //newCar1.IsDrivable = true;
            //newCar2.IsDrivable = false; 
            //newCar3.IsDrivable = true;



            //Call each of the methods for each car

            newCar1.MakeEngineNoise();
            newCar2.MakeEngineNoise();
            newCar3.MakeEngineNoise();

            newCar1.MakeHonkNoise();
            newCar2.MakeHonkNoise();
            newCar3.MakeHonkNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2***********

            foreach(var cars in newCarLot.LotList) {
                Console.WriteLine($"Year:{cars.Year}, Make: {cars.Make}, Model: {cars.Model}");
            }

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
