using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_pattern
{
	class CAbstraction
	{
		IBridge implementation;
		Dictionary<string, double> products;

		//Method 1 
		//More common, recibe a specific implementation
		public CAbstraction(IBridge implementation, Dictionary<string, double> products)
		{
			this.implementation = implementation;
			this.products = products;
		}

		//Method 2
		//careful this is not a fabric
		public CAbstraction(int Type, Dictionary<string, double> products)
		{
			if (Type == 1)
				implementation = new CImplementation1();
			if (Type == 2)
				implementation = new CImplementation2();
			if (Type == 3)
				implementation = new CImplementation3();

			this.products = products;
		}


		public void ShowTotals()
		{
			implementation.ShowTotals(products);
		}


		public void Lists()
		{
			implementation.ListProducts(products);
		}


	}
}
