using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric_pattern
{
	class CCreator
	{

		public static IVehicle FabricMethod(int money)
		{
			IVehicle temp = null;

			//Seleccionamos el tipo de instancia segun nuestras reglas

			if(money >= 1000000)
			{
				temp = new CPlane();
			}
			else if (money >= 200000)
			{
				temp = new CCar();
			}
			else
			{
				temp = new CBici();
			}

			return temp;

		}

	}
}
