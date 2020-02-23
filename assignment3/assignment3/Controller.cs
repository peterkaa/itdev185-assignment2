using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace assignment3
{
    class Controller
    {
        public void ControlMethod()
        {
            Console.ReadLine();
            Console.WriteLine("Welcome to the generic demo");
            Console.WriteLine("Assigning string values to Generic Class.......");
            Thread.Sleep(3000);

            Generic<string, string> theGeneric1 = new Generic<string, string> { firstProperty = "Red", secondProperty = "Blue" };

            Console.WriteLine(theGeneric1.ToString());
            Thread.Sleep(3000);

            Console.WriteLine("\nNow I will create another instance of the same class using an integer instead");
            Thread.Sleep(3000);

            Generic<int, int> theGeneric2 = new Generic<int, int> { firstProperty = 5, secondProperty = 6 };

            Console.WriteLine(theGeneric2.ToString());
            Thread.Sleep(3000);

            Console.WriteLine("\nOh. you'd like me to change them to a double? alright!");
            Thread.Sleep(3000);

            Generic<double, double> theGeneric3 = new Generic<double, double> { firstProperty = 3.14159265, secondProperty = 9.5630982 };

            Console.WriteLine(theGeneric3.ToString());
            Thread.Sleep(3000);

            Console.WriteLine("\nWow! So cool! Using the same class but different data types!");
            Console.WriteLine("Press enter to end!");
            Console.ReadLine();

        }
    }
}
