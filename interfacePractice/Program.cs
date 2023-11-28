using interfacePractice;
using interfacePractice.Company;
using interfacePractice.employee;
using interfacePractice.employee.WIT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace interfacePractice
{
	/// <summary>
	/// 我能說這邊是控制反轉中心（IOC）
	/// </summary>
    internal class Program
    {
		#region OO物件導向中有五大原則S、O、L、I、D
		/*
			單一職責原則 Single Responsibility Principle (SRP) => 就一個類別而言，應該只有一個引起它變化的原因：著重在『封裝』，封裝的體現。
			開放封閉原則 Open-Closed Principle (OCP) => 軟體實體（類別、模組、函式等等）應該對擴展開放，而對修改封閉，講白了就是模組化：也是OOP最終的究極目標。
			里氏替換原則 Liskov Substitution Principle (LSP) => 子類別需要有父類別的功能，就算不改變也不會出錯：著重在『繼承』。
			介面隔離原則 Interface Segregation Principle (ISP) => 設計介面時因考量需求，別給低階模組實作時有空實作的機會：著重在『介面』的使用&設計。
			依賴反轉原則 Dependency Inversion Principle (DIP) => 將高階模組－>低階模組的關係改變。高階模組不應該依賴於低階模組。兩者都應該依賴抽象：透過依賴注入（DI）的實作方式實現控制反轉（IOC）概念。
		*/
		#endregion


		#region 依賴反轉Instance
		// 低階模組實例
		static wisen mWisen = new wisen();
        static ryder mRyder = new ryder();
        static todd mTodd = new todd();
        static linc mLinc = new linc();
        

        // 高階模組實例
        static Engineer SW1 = new Engineer(mWisen);
        static Engineer SW2 = new Engineer(mLinc);
        static Engineer FW1 = new Engineer(mTodd);
        static Engineer PLC1 = new Engineer(mRyder);
		#endregion

		// class建構子（多載、:this()、選擇性參數）使用
		static classTest test1 = new classTest();
		static classTest test2 = new classTest("test");
		static classTest test3 = new classTest(87);
		static classTest test4 = new classTest("naughty guy",8787,"ssssssssssssssss");

		static Wisen Wisen = new Wisen();
		static WIT WIT = new WIT(Wisen);

		static void Main(string[] args)
        {
            SW1.Work();
            FW1.Work();
            PLC1.Work();
            SW2.Work();
			
			// 子類別覆寫差異實作方法
			classTest.callClass();

			WIT.doWork();
			WIT.showInFo();

			Console.WriteLine($@"Name:{test1.name}，Weight:{test1.weight}");
			Console.WriteLine($@"Name:{test2.name}，Weight:{test2.weight}");
			Console.WriteLine($@"Name:{test3.name}，Weight:{test3.weight}");
			Console.WriteLine($@"Name:{test4.name}，Weight:{test4.weight}，Descript:{test4.descript}");
			Console.ReadLine();
        }
    }
}
