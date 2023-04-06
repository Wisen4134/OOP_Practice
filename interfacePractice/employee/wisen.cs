using interfacePractice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice.Programers
{
    /// <summary>
    /// 菜雞軟體工程師
    /// </summary>
    internal class wisen : ISoftwareEngineer
    {
        public void sitDown()
        {
            Console.WriteLine($"wisen sit!\r\n");
        }

        public void standUp()
        {
            Console.WriteLine($"wisen standUp!\r\n");
        }

        public void writeCSharp()
        {
            Console.WriteLine($"wisen writeCSharp!\r\n");
        }

        public void writeJava()
        {
            Console.WriteLine($"wisen writeJava!\r\n");
        }

        public void writeJavaScript()
        {
            Console.WriteLine($"wisen writeJavaScript!\r\n");
        }

        public void writeMSSQL()
        {
            Console.WriteLine($"wisen writeMSSQL!\r\n");
        }

        public void writeVue3()
        {
            Console.WriteLine($"wisen writeVue3!\r\n");
        }

        private void drinkWater()
        {
            Console.WriteLine($"wisen drink! but this act isn`t below SW!");
        }
    }
}
