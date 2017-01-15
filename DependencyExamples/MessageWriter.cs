using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyExamples
{
    public class MessageWriter
    {
        public string MorningMessage()
        {
            return "Good Morning.";
        }

        public string AfternoonMessage()
        {
            return "Good Afternoon.";
        }

        public string EveningMessage()
        {
            return "Good Evening.";
        }
    }
}
