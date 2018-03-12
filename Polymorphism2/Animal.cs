using System;
using Polymorphism;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Animal
    {
        private string type;
        private string color;
        private string weight;
        private string height;
        private int age;
        private int numOfLegs;

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age cannot be less then 0");
                    Console.ReadLine();
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Color
        {
            get { return this.Color; }
            set { this.color = value; }
        }

        public void move()
        {
            Console.WriteLine("Moved");
            Console.ReadLine();
        }

        public void makeNoise()
        {

        }

    }
}
