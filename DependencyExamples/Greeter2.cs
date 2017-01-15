using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyExamples
{
    public class Greeter2
    {
        public Greeter2()
        {
            // empty, default constructor...
        }

        public string Greet(int currentHour)
        {
            string response = "";
            if (currentHour < 12)
            {
                response = "Good Morning.";
            }
            else if (currentHour < 18)
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
