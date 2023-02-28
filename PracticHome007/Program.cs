using System;
using System.Diagnostics.CodeAnalysis;

namespace PracticHome007
{
    public class Program
    {
        static void Main(string[] args)
        {
            Phone proMax = new Phone(174.6);
            proMax.PhoneStats();
            proMax.receiveCall("Artem");
            Console.WriteLine("--------------------");
            proMax.ShowStats();
            proMax.receiveCall("Dina", 054696895);
            
            //Phone obj = new Phone();
            //int number = 12;
            //Phone car = new Phone();    
            //car.Care(12);
            //car.Care(ref number );
            //car.Care((long)2);

        }

         

        
        
        
    }
}