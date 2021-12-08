using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Prototype.Components
{
    class TouchPad
    {
        public string Button { get; set; }

        public TouchPad Clone() { return new TouchPad { Button = this.Button }; }
    }
}
