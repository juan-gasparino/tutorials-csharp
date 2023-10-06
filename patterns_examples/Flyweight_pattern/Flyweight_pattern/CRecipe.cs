using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_pattern
{
	internal class CRecipe: IFlyweight
	{

		private string _name;
		private double _cost;
		private double _sell;


		public void SetName(string name)
		{
			_name = name;
		}


		public void CalculateCost()
		{
			foreach (char character in _name)
			{
				_cost += (int)character;
				_sell = _cost * 1.30;
			}
		}


		public void Show()
		{
			Console.WriteLine("{0} cost {1}", _name, _sell);
		}


		public string ObtainName()
		{
			return _name;
		}

	}
}
