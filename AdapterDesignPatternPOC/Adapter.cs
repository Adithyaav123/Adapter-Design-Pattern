using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternPOC
{
    internal class Adapter : ITarget
    {
        private readonly Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        public string GetRequest()
        {
            return $"You have to'{this.adaptee.GetSpecificRequest()}'";
        }

    }
}
