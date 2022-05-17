using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Cat : Animal, ILand
    {
        private int numberOfLength;
        public int NumberOfLength
        {
            get { return numberOfLength; }
            set { numberOfLength = value; }
        }

        public Cat(int numberOfLength,bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood)
        {
            NumberOfLength = numberOfLength;
        }

        public override void sayHello(int mood)
        {
            
        }

        public override void sayHello()
        {
            //Console.WriteLine("Cats usually make a meow~sound when they greet people");
        if (base.isMood() == 0)
         Console.WriteLine("When cats are frightened and upset:they make a hiss sound");
            else if (base.isMood() == 1)

                Console.WriteLine("when cats are in a good mood they make: purr, purr");
            else
                Console.WriteLine("Cats usually make a meow~");
        }

        public int getNumberOfLegs()
        {
            return NumberOfLength;
        }
        public void setNumberOfLegs(int a)
        {
            NumberOfLength = a;
        }
    }
}
