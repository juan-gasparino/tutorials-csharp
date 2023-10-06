using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_pattern
{
	class CImplementation1: IBridge
	{

		public void ShowTotals(Dictionary<string, double> products)
		{
			double total = 0;
			int quantity = 0;

			foreach (KeyValuePair <string, double> product in products)
			{
				total += product.Value;
				quantity++;
			}

			Console.WriteLine("The total of {0} products is ${1}", quantity, total);
		
		}

		public void ListProducts(Dictionary<string, double> products)
		{
			foreach (KeyValuePair<string, double> product in products)
			{
				Console.WriteLine(product.Key);
			}
		}

	}
}
