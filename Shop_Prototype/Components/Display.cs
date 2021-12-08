using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Prototype.Components
{
    class Display
    {
        public string Resolution { get; set; }

        public Display Clone() { return new Display { Resolution = this.Resolution }; }
    }
}
