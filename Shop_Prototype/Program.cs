using System;
using Shop_Prototype.Devices;
using Shop_Prototype.Components;

namespace Shop_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Выберете устройство:\n");
            Console.Write("(1) Laptop\n" +
                "(2) Desktop\n" +
                "(3) Notebook\n" +
                "(4) Tablet\n");
            int device = Convert.ToInt32(Console.ReadLine());

            switch(device)
            {
                case 1:
                    Device laptop = new Laptop();
                    Device clonedLaptop = laptop.Clone();
                    laptop.Mouse.Button = "1-button";
                    clonedLaptop.Mouse.Button = "3-button";
                    laptop.GetInfo();
                    clonedLaptop.GetInfo();
                    break;
                case 2:
                    Device desktop = new Desktop();
                    Device clonedDesktop = desktop.Clone();
                    desktop.GetInfo();
                    clonedDesktop.GetInfo();
                    break;
                case 3:
                    Device notebook = new Notebook();
                    Device clonedNotebook = notebook.Clone();
                    notebook.GetInfo();
                    clonedNotebook.GetInfo();
                    break;
                case 4:
                    Device tablet = new Tablet();
                    Device clonedTablet = tablet.Clone();
                    tablet.GetInfo();
                    clonedTablet.GetInfo();
                    break;
            }
        }
    }
}
