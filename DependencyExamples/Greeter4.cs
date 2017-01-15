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
        private HolidayMessageWriter _msgWriter;

        public Greeter4(HolidayMessageWriter msgWriter)
        {
            _msgWriter = msgWriter;
        }

        public string Greet()
        {
            return _msgWriter.GetMessage();
        }
    }
}
