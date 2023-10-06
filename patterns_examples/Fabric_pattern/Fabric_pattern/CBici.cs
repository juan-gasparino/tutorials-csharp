using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric_pattern
{
	class CBici: IVehicle
	{

		public void TurnOn()
		{
			Console.WriteLine("La bici no tiene motor");
		}

		public void SpeedUp()
		{
			Console.WriteLine("Pedalea mas");
		}

		public void Stop()
		{
			Console.WriteLine("Clava el freno de atras");
		}

		public void Turn()
		{
			Console.WriteLine("Gira la bici");
		}

	}
}
