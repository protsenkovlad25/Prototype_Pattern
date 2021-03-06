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
    class Tablet: Device
    {
        public Tablet()
        {
            Display = new Display { Resolution = "UltraHD" };
            Keyboard = new Keyboard { Number = "-" };
            TouchPad = new TouchPad { Button = "-" };
            Mouse = new Mouse { Button = "-" };
            CPU = new CPU { Number = "8cores" };
            RAM = new RAM { Number = "2Gb" };
            ROM = new ROM { Number = "128Gb" };
        }

        public override Device Clone()
        {
            return new Tablet()
            {
                Display = this.Display.Clone(),
                Keyboard = this.Keyboard.Clone(),
                TouchPad = this.TouchPad.Clone(),
                Mouse = this.Mouse.Clone(),
                CPU = this.CPU.Clone(),
                RAM = this.RAM.Clone(),
                ROM = this.ROM.Clone()
            };
        }
    }
}
