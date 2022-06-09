using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Animal
{
    /*
     * 1. Create the abstract class Animal. This class has one field - name and two methods: getName() and makeNoise(). 
     * The makeNoise() method should be abstract. Derive two classes from Animal - Dog and Cat and implement the getName() and the makeNoise() method for each class. 
     * Create a container to store animals and then demonstrate how the makeNoise() method works for each type of animal. (40 points)
     */ 
    public abstract class Animal
    {
        private string x;

        public string getX() { return x; }

        public abstract void makeNoise();
    }
    
    public class Dog : Animal
    {
        private string name;

        //public string name(string newName) /*: base(newName)*/
        //{
        //    getName(newName);
        //}

        public void getName(string newName)
        {
            name = newName;
        }

        public string getName()
        {
            return name;
        }

        public override void makeNoise()
        {
            Console.WriteLine("Dog: Bark");
        }
    }

    public class Cat : Animal
    {
        private string name;
        
        public void getName(string newName)
        {
            name = newName;
        }

        public string getName()
        {
            return name;
        }

        public override void makeNoise()
        {
            Console.WriteLine("Cat: Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] Animals = new string[] { "Dog", "Cat" };
            Dog dname = new Dog();
            Cat cname = new Cat();
            for (int i = 0; i < 2; i++)
            {
                if (Animals[i] == "Dog")
                {
                    dname.makeNoise();
                }
                else if (Animals[i] == "Cat")
                {
                    cname.makeNoise();
                }
            }
            Console.ReadLine();
        }
    }
}