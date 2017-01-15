using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyExamples;
using Microsoft.Practices.Unity;

namespace Greeter6_Application
{
    class Program
    {
        private IUnityContainer _container = new UnityContainer();

        static void Main(string[] args)
        {
            var g = new Greeter6();
            Console.WriteLine(g.Greet());

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
