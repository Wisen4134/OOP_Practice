using interfacePractice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice.employee
{
    /// <summary>
    /// PLC工程師
    /// </summary>
    internal class ryder : IPLCEngineer
    {
        public void writePLC()
        {
            Console.WriteLine($"ryder PLC!\r\n");
        }

        public void writeVTSCADA()
        {
            Console.WriteLine($"ryder VT!\r\n");
        }
    }
}
