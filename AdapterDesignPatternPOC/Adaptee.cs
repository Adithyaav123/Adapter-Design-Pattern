using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternPOC
{
    internal class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Provide the Credentials.";
        }
    }
}
