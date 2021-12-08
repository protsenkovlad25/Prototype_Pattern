using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Prototype.Components
{
    class CPU
    {
        public string Number { get; set; }

        public CPU Clone() { return new CPU { Number = this.Number }; }
    }
}
