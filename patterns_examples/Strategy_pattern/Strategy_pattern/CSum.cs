using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern
{
	class CSum: IOperation
	{
		public double operation(double a, double b)
		{
			return a + b;
		}
	}
}
