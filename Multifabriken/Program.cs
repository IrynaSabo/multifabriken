using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
             bool runMeny = true;
             var kundKorg = new VaruKorg();

            //Välkomstmeddelande och listan av alla produkter som går att beställa
            Console.WriteLine("========  Välkommen till multifabriken  =======");
            Console.WriteLine(" Du kan beställa följande produkter:\t\n" +
            "  -  bilar, styk  \t\n  -  godis, i påsar 100 gramm \t\n  -  rör, meter med viss diameter \t\n  -  havremjölk, 1 liter förpackning med viss fethalt\t\n");

            //Huvudmeny där man kan välja (1) beställa en produkt, (2) skriva ut alla sina beställda
            //produkter, (3) avsluta programmet.
            while(runMeny)
            {
                Console.WriteLine("====================  Meny  ===================");
                Console.WriteLine(" [1]  Beställa produkt ");
                Console.WriteLine(" [2]  Skriva ut alla beställda produkter ");
                Console.WriteLine(" [3]  Avsluta programmet ");
                Console.Write("   Välj : ");
            var usersValFromMeny = Convert.ToInt32(Console.ReadLine());

            switch(usersValFromMeny)
            {
              case 1: 
              Console.Clear();
              Console.WriteLine("Vilken produkt vill du beställa?");
              System.Console.WriteLine("Välj från meny");
              System.Console.WriteLine("   [1]  en bil");
              System.Console.WriteLine("   [2]  godis");
              System.Console.WriteLine("   [3]  rör");
              System.Console.WriteLine("   [4]  havremjölk");
              Console.Write("  Välj : ");
              var valtVariant = Convert.ToInt32(Console.ReadLine());
              
              if(valtVariant==1)
              {
                   Console.Write("Ange bilmärke: ");
                   var typeOfCar = Console.ReadLine();
                   Console.Write("Ange registreringsnummer:");
                   var regNumber = Console.ReadLine();
                   Console.Write("Ange färg: ");
                   var colorOfCar = Console.ReadLine();

                   kundKorg.AddCar(new Car(typeOfCar,regNumber,colorOfCar));
              }
              else if(valtVariant==2)
              {
                  Console.Write("Ange smaken: ");
                  var flavourOfCandy = Console.ReadLine();
                  Console.Write("Ange hur många påsar vill du beställa: ");
                  var quantityOfCandy = Convert.ToInt32(Console.ReadLine());

                  kundKorg.AddCandy(new Candy(flavourOfCandy,quantityOfCandy));
              }
              else if(valtVariant==3)
              {
                  Console.Write("Ange önskad diameter, mm: ");
                  var diameterOfPipe = Convert.ToInt32(Console.ReadLine());
                  Console.Write("Ange önskad längd, meter: ");
                  var lengthOfPipe = Convert.ToInt32(Console.ReadLine());

                  kundKorg.AddPipe(new Pipe(diameterOfPipe,lengthOfPipe));
              }
              else if(valtVariant==4)
              {
                  Console.Write("Ange önskad fetthalt: ");
                  var fatOfMilk = Convert.ToDouble(Console.ReadLine());
                  Console.Write("Ange hur många liter vill du beställa: ");
                  var quantityOfMilk = Convert.ToInt32(Console.ReadLine());

                  kundKorg.AddOatmilk(new Oatmilk(fatOfMilk,quantityOfMilk));
              }
              else
              {
                  Console.Write("Fel val! Prova igen!");
              }
              break;
              case 2:
              Console.WriteLine("Din varukorg innehåller följande produkter: \n");
                 kundKorg.showCars();
                 kundKorg.showCandies();
                 kundKorg.showPipes();
                 kundKorg.showMilk();
              break;
              case 3:
                 runMeny = false;
                 Console.WriteLine("Du valde att avsluta programmet. Hej då! ");
              break;
              default:
                Console.WriteLine("Fel val! Prova igen!");
              break;
            }

          }
                    
        }
    }
}
