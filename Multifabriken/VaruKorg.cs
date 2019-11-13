using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class VaruKorg
    {
        private List<Car> cars;
        private List<Candy> candies;
        private List<Pipe> pipes;
        private List<Oatmilk> milk;

        public VaruKorg() //konstruktorn
        {
            cars = new List<Car>();
            candies = new List<Candy>();
            pipes = new List<Pipe>();
            milk = new List<Oatmilk>();
        }
        
        // Fyra metoder som skapar objekter av respektive klass och lägger till viss lista
        public void AddCar( Car carToAdd)
        {
          cars.Add(carToAdd);
        }
        public void AddCandy(Candy candyToAdd)
        {
          candies.Add(candyToAdd);
        }
        public void AddPipe(Pipe pipeToAdd)
        {
          pipes.Add(pipeToAdd);
        }
        public void AddOatmilk(Oatmilk milkToAdd)
        {
          milk.Add(milkToAdd);
        }
       // Fyra metoder som skriver ut information om objekter från respektive lista(om lista är inte tom)
       // eller ut meddelandet att listan är tom
        public void showCars()
        {
            if(cars.Count!= 0)
            {
                foreach(var car in cars)
                {
                  car.ShowInfo();
                }
            }
            else{
                Console.WriteLine("Du inte bestälde några bilar");
            }

        }
        public void showCandies()
        {
            if(candies.Count!= 0)
            {
                foreach(var candy in candies)
                {
                  candy.ShowInfo();
                }
            }
            else{
                Console.WriteLine("Du inte bestälde några godis");
            }

        }
       public void showPipes()
        {
            if(pipes.Count!= 0)
            {
                foreach(var pipe in pipes)
                {
                  pipe.ShowInfo();
                }
            }
            else{
                Console.WriteLine("Du inte bestälde några rör.");
            }

        }
       public void showMilk()
        {
            if(milk.Count!= 0)
            {
                foreach(var mjolk in milk)
                {
                  mjolk.ShowInfo();
                }
            }
            else{
                Console.WriteLine("Du inte bestälde någon mjölk.");
            }

        }

    }
    
}