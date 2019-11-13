using System;

namespace Multifabriken
{
    class Car
    {
        private string type;//klass medlemar
        private string number;
        private string color;

        public Car (string typeToSet, string numberToSet, string colorToSet)//konstruktor
        {
            type = typeToSet;
            number = numberToSet;
            color = colorToSet;
        }

        public void ShowInfo()//metod som skriver ut information om objekt
        {
         Console.WriteLine("Bil: " +color +" " + type + " "+number+ ".");
        }
    }
}