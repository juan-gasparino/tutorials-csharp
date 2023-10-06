using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric_pattern
{
	class CCar: IVehicle
	{
		public void TurnOn()
		{
			Console.WriteLine("Brum brum");
		}

		public void SpeedUp()
		{
			Console.WriteLine("Pisa mas el acelerador");
		}

		public void Stop()
		{
			Console.WriteLine("Pisa fuerte el freno");
		}

		public void Turn()
		{
			Console.WriteLine("Gira el volante suavemente");
		}

	}
}
