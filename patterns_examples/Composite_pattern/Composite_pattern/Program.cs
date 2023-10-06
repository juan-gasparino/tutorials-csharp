using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_pattern
{
	class Program
	{
		static void Main(string[] args)
		{
			IComponent<string> tree = new Composite<string>("root");
			IComponent<string> work = tree; //initial position

			string option = "";
			string data = "";

			while (option != "6")
			{

				Console.WriteLine("I'm in {0}", work.name);
				Console.WriteLine("1-Add composite, 2-Add Component, 3-Delete, 4-Search, 5-Show, 6-Exit");
				option = Console.ReadLine();
				Console.WriteLine("--------------");

				if (option == "1")
				{
					Console.WriteLine("Give me a composite: ");
					data = Console.ReadLine();

					IComponent<string> compo = new Composite<string>(data);
					work.Adding(compo);
					work = compo; //update position
				}

				if (option == "2")
				{
					Console.WriteLine("Gime me a component name: ");
					data = Console.ReadLine();

					work.Adding(new Component<string>(data));
				}

				if (option == "3")
				{
					Console.WriteLine("Give me the element to delete: ");
					data = Console.ReadLine();

					work = work.Delete(data);
				}

				if (option == "4")
				{
					Console.WriteLine("Give me the element to find: ");
					data = Console.ReadLine();

					work = tree.Search(data);
				}

				if (option == "5")
				{
					Console.WriteLine(tree.Show(0));
				}

			}

		}

	}

}