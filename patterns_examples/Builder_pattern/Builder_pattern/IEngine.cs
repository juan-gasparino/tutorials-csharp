using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
	interface IEngine
	{
		string specifications();
	}

	//Se ponen las clases dentro de la interface solo por agilidad en un prog real habria que hacerlo con clases separadas
	class EngineBasic: IEngine
	{
		public string specifications()
		{
			return "Motor 4 cilindros";
		}
	}

	class EngineBig: IEngine
	{
		public string specifications()
		{
			return "Motor V8";
		}
	}

}
