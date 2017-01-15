using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyExamples;

namespace Greeter5_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var mw = new HolidayMessageWriter2();
            var g = new Greeter5(mw);
            Console.WriteLine(g.Greet());

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
