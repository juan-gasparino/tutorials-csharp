using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_pattern
{
	class Program
	{
		static void Main(string[] args)
		{

			int res = 0;

			ITarget calc = new CCalcu();

			res = calc.Sum(4, 3);
			Console.WriteLine("The result is {0}", res);
			Console.WriteLine("\r\n---------------\r\n");

			calc = new CAdapter();

			res = calc.Sum(5, 6);
			Console.WriteLine("The result is {0}", res);
			Console.WriteLine("\r\n---------------\r\n");

		}

	}

}