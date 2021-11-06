using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_Prototype.Components;

namespace Shop_Prototype.Devices
{
    abstract class Device
    {
        public Keyboard Keyboard { get; set; }
        public TouchPad TouchPad { get; set; }
        public Display Display { get; set; }
        public Mouse Mouse { get; set; }
        public CPU CPU { get; set; }
        public RAM RAM { get; set; }
        public ROM ROM { get; set; }

        public abstract Device Clone();
        public void GetInfo()
        {
            Console.WriteLine(
                $"Keybord: {Keyboard.Number}\n" +
                $"Dispay: {Display.Resolution}\n" +
                $"Mouse: {Mouse.Button}\n" +
                $"TouchPad: {TouchPad.Button}\n" +
                $"CPU: {CPU.Number}\n" +
                $"RAM: {RAM.Number}\n" +
                $"ROM: {ROM.Number}\n");
        }
    }
}
