using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_pattern
{
	class CAdapter: ITarget
	{
		CCalculArray adapted = new CCalculArray();
		
		public int Sum(int a, int b)
		{

			double r = 0;

			int[] operands = { a, b };

			r = adapted.sum(operands);

			return (int)r;

		}

	}
}