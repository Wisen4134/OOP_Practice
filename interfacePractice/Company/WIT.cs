using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfacePractice.Interfaces;
namespace interfacePractice.Company
{
	/// <summary>
	/// 高階模組（Caller）
	/// </summary>
	class WIT
	{
		/// <summary>
		/// 使用的介面
		/// </summary>
		IWITpartner WITpartner;


		/// <summary>
		/// 建構子、依賴注入
		/// </summary>
		/// <param name="ai_witpartner"></param>
		public WIT(IWITpartner ai_witpartner)
		{
			this.WITpartner = ai_witpartner;
		}

		public bool doWork()
		{
			return WITpartner.doWork();
		}

		public void showInFo()
		{
			string ls_info = $"姓名：{WITpartner.name}\n年齡：{WITpartner.age}\n電話：{WITpartner.phoneNumber}\n職位：{WITpartner.position}\n技能：";
			for (int i = 0; i < WITpartner.skill.Length; i++)
				ls_info += WITpartner.skill[i] + "、";					
			ls_info = ls_info.Substring(0,ls_info.Length - 1);
			Console.WriteLine(ls_info);
		}
	}
}
