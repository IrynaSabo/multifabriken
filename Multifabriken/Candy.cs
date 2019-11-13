using System;

namespace Multifabriken
{
    class Candy
    {
        private string flavour;//klass medlemmar
        private int quantity;

        public Candy(string flavourToSet, int quantityToSet)//konstruktorn
        {
          flavour = flavourToSet;
          quantity = quantityToSet;
        }

        public void ShowInfo()//metod som skriver ut information om objekt
        {
            Console.WriteLine("Godis: " + quantity + " påsar med " + flavour + " smak.");
        }

    }
}