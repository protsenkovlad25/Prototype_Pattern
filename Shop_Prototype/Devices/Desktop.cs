using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Shop_Prototype.Components;

namespace Shop_Prototype.Devices
{
    class Desktop : Device
    {
        public Desktop()
        {
            Display = new Display { Resolution = "-" };
            Keyboard = new Keyboard { Number = "-" };
            TouchPad = new TouchPad { Button = "-" };
            Mouse = new Mouse { Button = "2-button" };
            CPU = new CPU { Number = "4cores" };
            RAM = new RAM { Number = "16Gb" };
            ROM = new ROM { Number = "1Tb" };
        }

        public override Device Clone()
        {
            return new Desktop();
        }
    }
}
