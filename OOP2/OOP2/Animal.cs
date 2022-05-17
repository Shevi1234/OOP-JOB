using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    abstract class Animal
    {


        private bool mammals;
        private bool carnivorous;
public static   int MOOD_HAPPY=1;
    public  static    int MOOD_SCARE=0;
        private int mood;
        public abstract void sayHello(int mood);
        public abstract void sayHello();
        //public int Mood
        //{
        //    get { return mood; }
        //    set { mood = value; }
        //}
        public Animal(bool mammals, bool carnivorous, int mood)
        {
            this.mammals = mammals;
            this.carnivorous = carnivorous;
            this.mood = mood;
        }
        public Animal()
        {
          
        }

        public bool isCarnivorous()
        {
            return carnivorous;
        }
        
        public void setCarnivorous(bool carnivorous)
        {
            this.carnivorous = carnivorous;

        }
        
        public bool isMammals()
        {
            return carnivorous;

        }
        public int isMood()
        {
            return mood;

        }


        public void setMammals(bool mammals)
        {
            this.mammals = mammals;
        }
    }

}
