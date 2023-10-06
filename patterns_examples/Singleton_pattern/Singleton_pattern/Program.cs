using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_pattern
{
	class Program
	{
		static void Main(string[] args)
		{

			CSingleton one = CSingleton.GetInstance();

			//Cambiamos cosas de la instancia

			one.setData("Juan", 30);

			Console.WriteLine(one);

			one.SomeProcess();

			CSingleton two = CSingleton.GetInstance();

			Console.WriteLine(two);//aunque cree otra instancia en realidad es la misma que uno

		}

	}

}