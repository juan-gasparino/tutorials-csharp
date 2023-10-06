using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern
{
	class Program
	{
		static void Main(string[] args)
		{
			string data = "";
			double x = 0;
			double y = 0;
			double r = 0;
			string option = "";

			IOperation myOperation = new CSum();

			while (option != "5")
			{
				Console.WriteLine("1 - Suma, 2 - Resta, 3 - Multi, 4 - Div, 5 - Exit");
				option = Console.ReadLine();

				if (option == "5")
					break;

				Console.WriteLine("Put value a");
				data = Console.ReadLine();
				x = Convert.ToDouble(data);

				Console.WriteLine("Put value b");
				data = Console.ReadLine();
				y = Convert.ToDouble(data);

				if (option == "1")
					myOperation = new CSum();

				if (option == "2")
					myOperation = new CSub();

				if (option == "3")
					myOperation = new CMulti();

				if (option == "4")
					myOperation = new CDiv();

				r = myOperation.operation(x, y);

				Console.WriteLine("The result is: {0}", r);

			}

		}
	}
}