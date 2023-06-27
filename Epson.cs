using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolymorphismInterface;

namespace PolymorphismInterface
{
    public class Epson : IPrinter
    {
        public void Speak(PrinterWindows printerWindows)
        {
            Console.WriteLine("Epson printer printing....");
            Console.WriteLine("Printer Windows display dimension : 10*11");
        }
    }
}