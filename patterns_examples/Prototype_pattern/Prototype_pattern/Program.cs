using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_pattern
{
	class Program
	{
		static void Main(string[] args)
		{
			CAdminPrototypes admin = new CAdminPrototypes();

			//Obtener dos instancias
			CPerson one = (CPerson)admin.GetPrototype("Person");
			CPerson two = (CPerson)admin.GetPrototype("Person");

			//Verificar que tengan los valores del prototype original
			Console.WriteLine(one);
			Console.WriteLine(two);
			Console.WriteLine("\r\n**************************\r\n");

			//Modificar el estado
			one.name = "Ana";
			two.name = "Julio";

			//Verificar que tengan los valores del prototype original
			Console.WriteLine(one);
			Console.WriteLine(two);
			Console.WriteLine("\r\n**************************\r\n");

			//Creamos una instancia
			CCar car = new CCar("Nissan", 250000);

			//lo agregamos al prototype
			admin.AddPrototype("Car", car);

			CCar car2 = (CCar)admin.GetPrototype("Car");
			car2.model = "Honda";

			//Verificar que cada uno tenga su estado
			Console.WriteLine(car);
			Console.WriteLine(car2);
			Console.WriteLine("\r\n**************************\r\n");

			//Obtenemos una instancia del costoso
			CValues val = (CValues)admin.GetPrototype("Values");
			Console.WriteLine(val);

		}

	}

}