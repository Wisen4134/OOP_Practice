using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice.Interfaces
{
    /// <summary>
    /// 定義PLC工程師介面(以預期行為所創建)
    /// </summary>
    internal interface IPLCEngineer
    {
        void writePLC();
        void writeVTSCADA();
        
    }
}
