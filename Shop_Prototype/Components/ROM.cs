using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Prototype.Components
{
    class ROM
    {
        public string Number { get; set; }

        public ROM Clone() { return new ROM { Number = this.Number }; }
    }
}
