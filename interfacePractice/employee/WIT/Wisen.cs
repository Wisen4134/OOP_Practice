using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfacePractice.Interfaces;
namespace interfacePractice.employee.WIT
{
	class Wisen : IWITpartner
	{
		public string name { get => this._name; set => this._name = value; }
		private string _name { get; set; }
		public decimal age { get => this._age; set => this._age = value; }
		private decimal _age { get; set; }
		public string phoneNumber { get => this._phoneNumber; set => this._phoneNumber = value; }
		private string _phoneNumber { get; set; }
		public string position { get => this._position; set => this._position = value; }
		private string _position { get; set; }
		public string[] skill { get => this._skill; set => this._skill = value; }
		private string[] _skill { get; set; }
		public string[] hobit { get => this._hobit; set => this._hobit = value; }
		private string[] _hobit { get; set; }

		public Wisen(string as_name = "Wisen", decimal ad_age = 25, string as_phomeNumber = "0987654321", string as_position = "Dog")
		{
			this.name = as_name;
			this.age = ad_age;
			this.phoneNumber = as_phomeNumber;
			this.position = as_position;
			this.skill = new string[2] { "挖土", "講幹話" };
			this.hobit = new string[2] { "看啦啦隊", "吃飯" };
		}
		public bool doWork()
		{
			return true;
		}
	}
}
