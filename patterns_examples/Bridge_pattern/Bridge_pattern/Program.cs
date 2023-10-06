using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_pattern
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Dictionary<string, double> products = new Dictionary<string, double>();

			products.Add("M101", 56.32);
			products.Add("M365", 78.11);
			products.Add("C654", 546.134);
			products.Add("M345", 364.122);
			products.Add("C567", 12.32);
			products.Add("D103", 54.45);
			products.Add("C710", 103.45);
			products.Add("D056", 23.21);

			//CAbstraction bridge = new CAbstraction(new CImplementation3(), products);
			CAbstraction bridge = new CAbstraction(2, products);

			bridge.ShowTotals();
			bridge.Lists();

		}

	}

}