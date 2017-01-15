using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace DependencyExamples
{
    public class Greeter6
    {
        private IMessageWriter _msgWriter;

        public Greeter6([Dependency] IMessageWriter msgWriter)
        {
            _msgWriter = msgWriter;
        }

        public string Greet()
        {
            return _msgWriter.GetMessage();
        }
    }
}
