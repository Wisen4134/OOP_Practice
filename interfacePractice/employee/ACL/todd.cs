using interfacePractice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice.employee
{
    /// <summary>
    /// 韌體工程師
    /// </summary>
    internal class todd : IFirmwareEngineer
    {
        public void hardwareFix()
        {
            Console.WriteLine($"todd HW fix!\r\n");
        }

        public void layout()
        {
            Console.WriteLine($"todd layout!\r\n");
        }

        public void writeC()
        {
            Console.WriteLine($"todd C!\r\n");
        }

        public void writeCplusplus()
        {
            Console.WriteLine($"todd C++!\r\n");
        }
    }
}
