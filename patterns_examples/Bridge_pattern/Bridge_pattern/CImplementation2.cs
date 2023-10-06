﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_pattern
{
	class CImplementation2: IBridge
	{

		public void ShowTotals(Dictionary<string, double> products)
		{
			double total = 0;
			double totalm = 0;
			double totalc = 0;
			double totald = 0;
			int quantity = 0;

			foreach (KeyValuePair<string, double> product in products)
			{
				total += product.Value;
				if (product.Key[0] == 'C')
					totalc += product.Value;
				if (product.Key[0] == 'M')
					totalm += product.Value;
				if (product.Key[0] == 'D')
					totald += product.Value;
				quantity++;
			}

			Console.WriteLine("The total of food is ${0}", totalc);
			Console.WriteLine("The total of med is ${0}", totalm);
			Console.WriteLine("The total of sports is ${0}", totald);

			Console.WriteLine("The total of {0} products is ${1}", quantity, total);

		}

		public void ListProducts(Dictionary<string, double> products)
		{
			foreach (KeyValuePair<string, double> product in products)
			{
				if (product.Key[0] == 'C')
					Console.ForegroundColor = ConsoleColor.Green;
				if (product.Key[0] == 'M')
					Console.ForegroundColor = ConsoleColor.Yellow;
				if (product.Key[0] == 'D')
					Console.ForegroundColor = ConsoleColor.Red;

				Console.WriteLine("{0} - {1}", product.Key, product.Value);

			}
		}

	}
}
