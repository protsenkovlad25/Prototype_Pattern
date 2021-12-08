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
    class Notebook: Device
    {
        public Notebook()
        {
            Display = new Display { Resolution = "FullHD" };
            Keyboard = new Keyboard { Number = "108" };
            TouchPad = new TouchPad { Button = "1-button" };
            Mouse = new Mouse { Button = "-" };
            CPU = new CPU { Number = "2cores" };
            RAM = new RAM { Number = "8Gb" };
            ROM = new ROM { Number = "512Gb" };
        }

        public override Device Clone()
        {
            return new Notebook()
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
