using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
	class CCar: IComponent
	{

		private string _model;
		private string _characteristics;

		public double cost;

		public CCar(string model, string characteristics, double cost)
		{
			_model = model;
			_characteristics = characteristics;
			this.cost = cost;
		}

		public void Doors(bool state) 
		{
			if (state)
				Console.WriteLine("Doors closed");
			else
				Console.WriteLine("Doors opened");
		}

		public override string ToString()
		{
			return String.Format("Model {0}, {1} \r\n", _model, _characteristics);
		}

		public double Cost()
		{
			return this.cost;
		}

		public string Works()
		{
			return "Engine running";
		}

	}
}
