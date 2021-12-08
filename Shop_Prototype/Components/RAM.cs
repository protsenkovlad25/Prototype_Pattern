using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Prototype.Components
{
    class RAM
    {
        public string Number { get; set; }

        public RAM Clone() { return new RAM { Number = this.Number }; }
    }
}
