using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Prototype.Components
{
    class Mouse
    {
        public string Button { get; set; }

        public Mouse Clone() { return new Mouse { Button = this.Button }; }
    }
}
