using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
	interface IWheels
	{
		string information();
	}

	//Se ponen las clases dentro de la interface solo por agilidad en un prog real habria que hacerlo con clases separadas
	class WheelsNormal : IWheels
	{
		public string information()
		{
			return "Llantas 14 pulgadas";
		}
	}

	class WheelsSuper : IWheels
	{
		public string information()
		{
			return "Llantas de 18 pulgadas, rines de aluminio";
		}
	}

}
