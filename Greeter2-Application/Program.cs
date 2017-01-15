using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyExamples;

namespace Greeter2_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = new Greeter2();
            Console.WriteLine(g.Greet(DateTime.Now.Hour));

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
