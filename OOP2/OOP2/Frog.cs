namespace OOP2
{
    class Frog : Animal,ILand,IWater
    {
        private int numberOfLength;
       

        public Frog(int numberOfLength, bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood)
        {

            this.numberOfLength = numberOfLength;
        }

        public override void sayHello(int mood)
        {

        }

        public override void sayHello()
        {
        
        }

        public int getNumberOfLegs()
        {
            return numberOfLength;
        }
        public void setNumberOfLegs(int numberOfLength)
        {
            this.numberOfLength = numberOfLength;
             
        }
        public bool hasGills()
        {
            return true;
        }
        public bool hasLaysEggs()
        {
            return true;
        }


    }
}
