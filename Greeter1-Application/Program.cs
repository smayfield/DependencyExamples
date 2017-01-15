using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyExamples;

namespace Greeter1_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = new Greeter1();
            Console.WriteLine(g.Greet());

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
