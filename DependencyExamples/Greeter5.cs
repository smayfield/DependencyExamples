using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyExamples
{
    public class Greeter5
    {
        private IMessageWriter _msgWriter;

        public Greeter5(IMessageWriter msgWriter)
        {
            _msgWriter = msgWriter;
        }

        public string Greet()
        {
            return _msgWriter.GetMessage();
        }
    }
}
