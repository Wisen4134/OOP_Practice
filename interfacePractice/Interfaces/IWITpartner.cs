using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice.Interfaces
{
	interface IWITpartner
	{
		string name { get; set; } 
		decimal age { get; set; }
		string phoneNumber { get; set; }
		string position { get; set; }
		
		string[] skill { get; set; }
		string[] hobit { get; set; }

		bool doWork();

	}
}
