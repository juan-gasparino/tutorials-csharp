using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
	interface IBuilder
	{
		void BuildEngine();
		void BuildChasis();
		void BuildWheels();
	}
}
