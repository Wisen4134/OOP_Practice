using interfacePractice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice.Company
{
    /// <summary>
    /// 高階模組依賴反轉,目前依賴控制反轉中心(Program.cs)
    /// </summary>
    internal class Engineer
    {
        ISoftwareEngineer _softwareEngineer;

        IFirmwareEngineer _firmwareEngineer;

        IPLCEngineer _pLCEngineer;
        

        public Engineer(ISoftwareEngineer softwareEngineer)
        {
            _softwareEngineer = softwareEngineer;
        }
        public Engineer(IPLCEngineer pLCEngineer) 
        { 
            _pLCEngineer = pLCEngineer;
        }
        public Engineer(IFirmwareEngineer firmwareEngineer)
        {
            _firmwareEngineer = firmwareEngineer;
        }
        

        public void Work()
        {
            if(_softwareEngineer != null )
            {
                _softwareEngineer.sitDown();
                _softwareEngineer.writeCSharp();
                _softwareEngineer.writeJava();
                _softwareEngineer.writeVue3();
                _softwareEngineer.writeJavaScript();
                _softwareEngineer.writeMSSQL();
                _softwareEngineer.standUp();
            }
           
            else if(_firmwareEngineer != null)
            {
                _firmwareEngineer.layout();
                _firmwareEngineer.writeC();
                _firmwareEngineer.writeCplusplus();
                _firmwareEngineer.hardwareFix();
            }
            else if(_pLCEngineer != null)
            {
                _pLCEngineer.writeVTSCADA();
                _pLCEngineer.writePLC();
            }
            else
            {
                Console.WriteLine("公司沒這個人~");
            }
        }
    }
}
