using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_pattern
{
	class CCalcu: ITarget
	{

		public int Sum(int a, int b)
		{
			return a + b;
		}

	}
}
