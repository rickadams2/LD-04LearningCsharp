using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClassSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.make = "Tesla";
            myCar.model = "2018";
            myCar.color = "black";

            myCar.Drive();
            myCar.Stop(); 

        }
    }
}
