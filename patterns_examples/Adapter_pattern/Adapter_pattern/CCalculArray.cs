using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_pattern
{
	internal class CCalculArray
	{

		public double sum(int[] operand)
		{
			int n = 0;
			int r = 0;

			for (n = 0; n < operand.Length; n++)
				r += operand[n];

			return r;
		}

	}
}
