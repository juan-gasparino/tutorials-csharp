using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_pattern
{
	class Program
	{
		static void Main(string[] args)
		{

			int i = 0;

			//Unshared states
			List<int> american = new List<int>();
			List<int> mexican = new List<int>();
			List<int> italian = new List<int>();

			List<int> soaps = new List<int>();
			List<int> meet = new List<int>();
			List<int> salads = new List<int>();

			List<int> fastFood = new List<int>();

			//instance of flyweight factory
			CFlyweightFactory flywf = new CFlyweightFactory();

			i = flywf.Adding("Burger");
			american.Add(i);
			meet.Add(i);
			fastFood.Add(i);

			i = flywf.Adding("Wisconsin cheese");
			american.Add(i);
			salads.Add(i);

			i = flywf.Adding("Minestrone");
			italian.Add(i);
			soaps.Add(i);

			i = flywf.Adding("Antipasto");
			italian.Add(i);
			salads.Add(i);

			i = flywf.Adding("Tacos al pastor");
			mexican.Add(i);
			meet.Add(i);
			fastFood.Add(i);

			i = flywf.Adding("Coditos");
			mexican.Add(i);
			soaps.Add(i);

			i = flywf.Adding("Nopales");
			mexican.Add(i);
			salads.Add(i);

			i = flywf.Adding("Pizza");
			italian.Add(i);
			fastFood.Add(i);

			foreach (int n in fastFood)
			{
				CRecipe recipe = (CRecipe)flywf[n];
				recipe.CalculateCost(); //Extrinsec value
				recipe.Show(); //Intrinsec value
			}

			Console.WriteLine("------------------");

			foreach (int n in american)
			{
				CRecipe recipe = (CRecipe)flywf[n];
				//recipe.CalculateCost(); //Extrinsec value
				recipe.Show(); //Intrinsec value
			}

			Console.WriteLine("------------------");
			i = flywf.Adding("Pizza");

			Console.WriteLine("------------------");

			foreach (int n in salads)
			{
				CRecipe recipe = (CRecipe)flywf[n];
				recipe.CalculateCost(); //Extrinsec value
				recipe.Show(); //Intrinsec value
			}

			int m = 0;

			for (m = 0; m < flywf.Counter; m++)
			{
				CRecipe recipe = (CRecipe)flywf[m];
				recipe.Show();
			}
		}

	}

}