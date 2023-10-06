using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric_pattern
{
	class Program
	{
		static void Main(string[] args)
		{
			string data;
			int money;
			IVehicle vehicle;

			Console.WriteLine("How much money do you have for your vehicle");
			data = Console.ReadLine();
			money = Convert.ToInt32(data);

			//Obtenemos el vehiculo de la fabrica
			vehicle = CCreator.FabricMethod(money);

			vehicle.TurnOn();
			vehicle.SpeedUp();
			vehicle.Stop();
			vehicle.Turn();
		}

	}

}