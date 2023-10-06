using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
	class Program
	{
		static void Main(string[] args)
		{
			CDirector myDirector = new CDirector();

			//Construimos un auto economico.
			CBuilderNormal normal = new CBuilderNormal();
			myDirector.Build(normal);

			//Obten auto
			CProduct car1 = normal.GetProduct();
			car1.ShowCar();
			Console.WriteLine("\n\r----------------------------\n\r");

			//Construimos un auto deportivo.
			CBuilderSport sport = new CBuilderSport();
			myDirector.Build(sport);

			//Obten auto
			CProduct car2 = sport.GetProduct();
			car2.ShowCar();
			Console.WriteLine("\n\r----------------------------\n\r");
		}

	}

}