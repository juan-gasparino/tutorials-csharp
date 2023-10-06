using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
	interface IChasis
	{
		string characteristics();
	}

	//Se ponen las clases dentro de la interface solo por agilidad en un prog real habria que hacerlo con clases separadas
	class ChasisBaisc: IChasis
	{
		public string characteristics()
		{
			return "Chasis de metal";
		}
	}

	class ChasisCarbonFiber: IChasis
	{
		public string characteristics()
		{
			return "Chasis fibra de carbono";
		}
	}

}
