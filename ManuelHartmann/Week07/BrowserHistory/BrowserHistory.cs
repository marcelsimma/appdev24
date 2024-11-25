using System;
using System.Collections.Generic;
using System.Text;

namespace ManuelHartmann.Week07.BrowserHistory
{
    public class BrowserHistory
    {
        public Stack<CallWebsite> WebSites { get; private set; }

        public BrowserHistory()
        {
            WebSites = new Stack<CallWebsite>();
        }

        public override string ToString()
        {
            if (WebSites.Count == 0)
                return "No websites in history.";

            var history = new StringBuilder();
            foreach (var website in WebSites)
            {
                history.AppendLine(website.ToString());
            }
            return history.ToString();
        }
    }
}