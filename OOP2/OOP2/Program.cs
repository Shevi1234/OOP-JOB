using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Animal[] pArr = new Animal[2];
            pArr[0] = new Cat(4, true, true,Animal.MOOD_HAPPY);
          //  pArr[0].setCarnivorous(true);
            pArr[1] = new Dog(4, true, true, Animal.MOOD_SCARE);

           

        Console.WriteLine( "the cat has "+ ((Cat)pArr[0]).getNumberOfLegs() +" legs");
            Console.WriteLine("the dog has " + ((Dog)pArr[1]).getNumberOfLegs()+ " legs");


            foreach (Animal p in pArr)
            {
                p.sayHello();
            }
            Console.ReadLine();
        }
       
    }
    
}
