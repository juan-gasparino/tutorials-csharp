using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsytems
{
	class CSystemBuy
	{

		public bool Buy()
		{
			string data = "";
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Introduce your credit card: ");
			data = Console.ReadLine();

			if(data == "1234")
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Pay accepted");
				return true;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Pay denied");
				return false;
			}

		}

	}

	class CSubsystemWarehouse
	{

		int quantity;

		public CSubsystemWarehouse()
		{
			quantity = 3;
		}

		public bool DispatchProduct()
		{
			bool status;
			if(quantity > 0)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Product ready for send");
				quantity--;
				status = true;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Product not available, wait to refill it");
				status = false;
			}
			return status;
		}

	}

	class CSubSystemSend
	{

		public void SendPackage()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Your package is ready to deliver");
		}

	}

}
