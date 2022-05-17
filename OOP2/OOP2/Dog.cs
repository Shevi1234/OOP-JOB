using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Dog : Animal, ILand
    {
        private int numberOfLength;
        

        public Dog(int numberOfLength, bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood)
        {
            
            this.numberOfLength = numberOfLength;
        }

        public override void sayHello(int mood)
        {
           
        }

        public override void sayHello()
        {
            if (base.isMood() == 0)
                Console.WriteLine("When they are frightened and upset:whooping ");
            else if(base.isMood() == 1)
                Console.WriteLine("When they feel comfortabl:they will bark loudly");
            else
            Console.WriteLine("Dogs usually greet people by:wagging their tails");
        }

        public int getNumberOfLegs()
        {
            return numberOfLength;
        }
        public void setNumberOfLegs(int numberOfLength)
        {
            this.numberOfLength = numberOfLength;

        }


    }
}
