using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyExamples
{
    public class Greeter3
    {
        private int _currentHour;

        public Greeter3(int currentHour)
        {
            _currentHour = currentHour;
        }

        public string Greet()
        {
            string response = "";
            if (_currentHour < 12)
            {
                response = "Good Morning.";
            }
            else if (_currentHour < 18)
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
