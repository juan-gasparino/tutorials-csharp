using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
	class Program
	{
		static void Main(string[] args)
		{
			//Create component IComponent
			IComponent myCar = new CCar("2018", " 4 Doors", 10000);

			Console.WriteLine(myCar);

			//We are working with Interfaces not classes myCar (IComponent)
			//If we want to access to parameter of myCar we have to use a CAST
			((CCar)myCar).Doors(true);

			Console.WriteLine("-----------");
			Console.WriteLine("Sound system decorator");

			myCar = new CSoundSystem(myCar);
			Console.WriteLine(myCar.Cost());
			Console.WriteLine(myCar.Works());
			Console.WriteLine(myCar);

			Console.WriteLine("-----------");
			Console.WriteLine("Nitro decorator");

			myCar = new CNitro(myCar);
			Console.WriteLine(myCar.Cost());
			Console.WriteLine(myCar.Works());
			Console.WriteLine(myCar);

			((CNitro)myCar).WithNitro();

			Console.WriteLine("-----------");
			Console.WriteLine("Suspention decorator");

			myCar = new CSuspention(myCar);
			Console.WriteLine(myCar.Cost());
			Console.WriteLine(myCar.Works());
			Console.WriteLine(myCar);

			//((CNitro)myCar).WithNitro(); //this is not working anymore cuz there is an aditional layer over the class now
			//((CCar)myCar).Doors(true); //this is not working anymore cuz there is an aditional layer over the class now
		}

	}

}