using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Prototype.Components
{
    class Keyboard
    {
        public string Number { get; set; }

        public Keyboard Clone() { return new Keyboard { Number = this.Number }; }
    }
}
