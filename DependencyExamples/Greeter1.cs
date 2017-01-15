using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyExamples
{
    public class Greeter1
    {
        public Greeter1()
        {
            // empty, default constructor...
        }

        public string Greet()
        {
            string response = "";
            if (DateTime.Now.Hour < 12)
            {
                response = "Good Morning.";
            }
            else if (DateTime.Now.Hour < 18)
            {
                response = "Good Afternoon.";
            }
            else
            {
                response = "Good Evening.";
            }
            return response;
        }
    }
}
