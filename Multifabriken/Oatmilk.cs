using System;

namespace Multifabriken
{
    class Oatmilk
    {
        private double fat_content;
        private int quantity;

        public Oatmilk(double fat_contentToSet, int quantityToSet)
        {
             fat_content = fat_contentToSet;
             quantity = quantityToSet;
        }
        
        public void ShowInfo()//metod som skriver ut information om objekt
        {
        Console.WriteLine("Havremjölk: " + quantity + " liter, " + fat_content + "% fetthalt.");
        }
    }
}