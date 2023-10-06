using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric_pattern
{
	class CPlane: IVehicle
	{

		public void TurnOn()
		{
			Console.WriteLine("Sigue el procedimiento");
		}

		public void SpeedUp()
		{
			Console.WriteLine("Mueve la palanca de gases");
		}

		public void Stop()
		{
			Console.WriteLine("Pon los flaps");
		}

		public void Turn()
		{
			Console.WriteLine("Mueve las alas");
		}

	}
}
