using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_pattern
{
	interface IBridge
	{
		void ShowTotals(Dictionary<string, double> products);
		void ListProducts(Dictionary<string, double> products);
	}
}
