using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_pattern
{
	class CFlyweightFactory
	{

		private List<IFlyweight> _flyweights = new List<IFlyweight>();
		private int _counter = 0;

		public int Counter { get => _counter; set => _counter = value; }


		public int Adding(string name)
		{

			//check if exist

			bool exist = false;

			foreach (IFlyweight flyweight in _flyweights)
			{
				if(flyweight.ObtainName() == name)
					exist = true;
			}

			if (exist) 
			{
				Console.WriteLine("The object already exist");
				return -1;
			}
			else
			{
				CRecipe myRecipe = new CRecipe();
				myRecipe.SetName(name);
				_flyweights.Add(myRecipe);
				_counter = _flyweights.Count;
				return _counter - 1;
			}
		}

		public IFlyweight this[int index]
		{
			get { return _flyweights[index]; }
		}

	}
}
