using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelHartmann.Week07.BrowserHistory
{
    public class CallWebsite
    {
        public string? WebsiteName { get; private set; }
        public DateTime CallTime { get; private set; }

        public CallWebsite(string? websiteName, DateTime callTime)
        {
            WebsiteName = websiteName;
            CallTime = callTime;
        }

        public override string ToString()
        {
            return $"Website: {WebsiteName}, Time: {CallTime}";
        }
    }
}
