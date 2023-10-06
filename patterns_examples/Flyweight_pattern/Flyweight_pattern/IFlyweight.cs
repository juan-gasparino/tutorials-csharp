using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_pattern
{
	interface IFlyweight
	{
		void SetName(string name);
		void CalculateCost();
		void Show();
		string ObtainName();
	}
}
