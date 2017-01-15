using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyExamples
{
    public class HolidayMessageWriter2 : IMessageWriter
    {
        public string GetMessage()
        {
            var msg = GetHolidayMessage();
            if (msg == "")
            {
                if (DateTime.Now.Hour < 12)
                {
                    msg = "Good Morning.";
                }
                else if (DateTime.Now.Hour < 18)
                {
                    msg = "Good Afternoon.";
                }
                else
                {
                    msg = "Good Evening.";
                }
            }
            return msg;
        }

        private string GetHolidayMessage()
        {
            if ((DateTime.Now.Month == 1) && (DateTime.Now.Day == 1))
            {
                return "Happy New Year!";
            }
            else
            {
                return "";
            }
        }
    }
}
