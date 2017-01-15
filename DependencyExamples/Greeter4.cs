using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyExamples
{
    public class Greeter4
    {
        private int _currentHour;
        private MessageWriter _msgWriter;

        public Greeter4(int currentHour, MessageWriter msgWriter)
        {
            _currentHour = currentHour;
            _msgWriter = msgWriter;
        }

        public string Greet()
        {
            string response = "";
            if (_currentHour < 12)
            {
                response = _msgWriter.MorningMessage();
            }
            else if (_currentHour < 18)
            {
                response = _msgWriter.AfternoonMessage();
            }
            else
            {
                response = _msgWriter.EveningMessage();
            }
            return response;
        }
    }
}
