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
    class Laptop: Device
    {
        public Laptop()
        {
            Display = new Display { Resolution = "HD" };
            Keyboard = new Keyboard { Number = "101" };
            TouchPad = new TouchPad { Button = "2-button" };
            Mouse = new Mouse { Button = "-" };
            CPU = new CPU { Number = "2cores" };
            RAM = new RAM { Number = "4Gb" };
            ROM = new ROM { Number = "320Gb" };
        }

        public override Device Clone()
        {
            return new Laptop()
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
