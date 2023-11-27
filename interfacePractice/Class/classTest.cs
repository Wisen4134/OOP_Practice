using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
	class classTest
	{
		// 封裝(屬性 => 也可稱為欄位)
		private string _name;
		public string name { get => this._name; set { this._name = value; } }
		private decimal _weight;
		public decimal weight { get => this._weight; set { this._weight = value; } }

		// get、set稱為存取子
		// 可限定物件初始化時的條件
		private string _descript;
		public string descript {
			get => this._descript;
			set { if (value.Length > 30)
					throw new Exception("別打那麼多字啦！拜託");
				else
				{
					this._descript = value;
				}
			}
		}

		// 多載(建構子、方法)
		// 用:this()重用主要方法
		// 給參數預設值會變成選擇性參數
		public classTest(string as_name = "default", decimal ad_weight = 99, string as_descript = "")
		{
			this.name = as_name;
			this.weight = ad_weight;
			this.descript = as_descript;
		}
		public classTest(string as_name) : this()
		{
			this.name = as_name;
		}

		public classTest(decimal ad_weight) : this()
		{
			this.weight = ad_weight;
		}

		/// <summary>
		/// 範例：繼承父類別後，將虛擬方法以override與New的差別。
		/// </summary>
		static public void callClass()
		{
			var realClassChild = new realClassChild();
			realClassChild.virtualMethod(); // 我是子類別！realClassChild
			((realClass)realClassChild).virtualMethod(); // 我是子類別！realClassChild

			var realClassButNew = new realClassButNew();
			realClassButNew.virtualMethod(); // 我是子類別！realClassButNew
			((realClass)realClassButNew).virtualMethod(); // 我是子類別！realClassChild
		}
	}


	/// <summary>
	/// 實體類別，可被實例化。
	/// </summary>
	class realClass
	{
		public string name { get; set; }

		/// <summary>
		/// 虛擬方法，不強迫衍生類別需要實作此方法
		/// </summary>
		public virtual void virtualMethod() => Console.WriteLine("我是父類別！");

	}

	/// <summary>
	/// realClassChild：衍生類別，繼承自抽象類別：虛擬方法用override覆寫 => 子類別轉型回父類別時一樣會用子類別的方法做
	/// </summary>
	class realClassChild : realClass
	{
		public override void virtualMethod() => Console.WriteLine("我是子類別！realClassChild");

	}

	/// <summary>
	/// realClassButNew：衍生類別：虛擬方法用new覆寫 => 子類別轉型回父類別時會用父類別的方法做
	/// </summary>
	class realClassButNew : realClass
	{

		public new void virtualMethod() => Console.WriteLine("我是子類別！realClassButNew");

	}


	/// <summary>
	/// 抽象類別，不能被實例化，通常拿來宣告共通特性、方法等。
	/// </summary>
	abstract class abstractClass
	{
		public string name { get; set; }

		/// <summary>
		/// 抽象方法，強迫繼承的衍生類別需要實作此方法（編譯器會提醒需要override此方法，有點像介面）
		/// </summary>
		public abstract void abstractMethod();


		/// <summary>
		/// 虛擬方法，不強迫衍生類別需要實作此方法
		/// </summary>
		public virtual void virtualMethod() => Console.WriteLine("我是父類別！");



	}


	/// <summary>
	/// abstractClassChild：衍生類別。也有可能是抽象類別，全看如何設計！
	/// </summary>
	class abstractClassChild : abstractClass
	{
		public override void abstractMethod() => Console.WriteLine("Hi! 我也做了 抽象方法");


	}
}
