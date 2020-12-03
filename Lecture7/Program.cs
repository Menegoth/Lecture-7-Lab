/// Week 7		Lab 1
/// File Name: Program.cs
/// @author: Antonio Monteiro


using System;

namespace Lecture7 {
    class Program {
        static void Main(string[] args) {

            //test constructors, get and set
            Pizza pizza1 = new Pizza("small", 2, 2, 3);
            Console.WriteLine("" + pizza1.GetSize() + pizza1.GetCheese() + pizza1.GetPepperoni() + pizza1.GetHam());
            Pizza pizza2 = new Pizza();
            pizza2.SetSize("medium");
            pizza2.SetCheese(4);
            pizza2.SetPepperoni(4);
            pizza2.SetHam(5);

            //test calculate cost
            Console.WriteLine(pizza1.CalculateCost());
            Console.WriteLine(pizza2.CalculateCost());

            //test tostring
            Console.WriteLine(pizza1);
            Console.WriteLine(pizza2.ToString());

        }
    }
}
