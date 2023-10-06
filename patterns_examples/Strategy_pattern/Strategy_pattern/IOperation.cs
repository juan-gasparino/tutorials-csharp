using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern
{
	interface IOperation
	{
		double operation(double a, double b);
	}
}