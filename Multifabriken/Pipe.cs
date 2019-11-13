using System;

namespace Multifabriken
{
    class Pipe
    {
        private int diameter;
        private int length;
        public Pipe (int diameterToSet, int lengthToSet)
        {
           diameter = diameterToSet;
            length = lengthToSet;
         }
         public void ShowInfo()//metod som skriver ut information om objekt
         {
            Console.WriteLine("Rör: " + length + " meter "+ diameter + " mm i diameter.");
         }
    }
    
}