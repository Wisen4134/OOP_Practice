using interfacePractice.Company;
using interfacePractice.employee;
using interfacePractice.Programers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    internal class Program
    {
        // 低階模組實例
        static wisen mWisen = new wisen();

        static ryder mRyder = new ryder();

        static todd mTodd = new todd();

        static linc mLinc = new linc();

        static god mGod = new god();

        // 高階模組實例
        static Engineer SW1 = new Engineer(mWisen);

        static Engineer SW2 = new Engineer(mLinc);

        static Engineer FW1 = new Engineer(mTodd);

        static Engineer PLC1 = new Engineer(mRyder);

        //static Engineer GOD = new Engineer(mGod);
        

        static void Main(string[] args)
        {
            SW1.Work();

            FW1.Work();

            PLC1.Work();

            SW2.Work();

            Console.ReadLine();
        }
    }
}
