using System;
namespace first
{
    class Hypoten{
        static void Main(string[] args){
            Console.WriteLine("Enter side A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());
            sideA *=sideA;
            Console.WriteLine("Enter side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());
            sideB*=sideB;
            double hyppie = Math.sqrt(sideA+sideB);
            Console.WriteLine("The length of the hypoteneuse is: "+hyppie);


            Console.ReadKey();
        }
    }
}