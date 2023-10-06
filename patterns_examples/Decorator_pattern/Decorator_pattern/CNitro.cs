using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
	class CNitro: IComponent
	{

		private IComponent _decoredTo;


		public CNitro(IComponent decoredTo)
		{
			_decoredTo = decoredTo;
		}


		public override string ToString()
		{
			return "Nitro system\r\n" + _decoredTo.ToString();
		}


		public double Cost()
		{
			return  _decoredTo.Cost() + 45000;
		}


		public string Works()
		{
			return _decoredTo.Works() + ", Nitro ready";
		}


		public void WithNitro()
		{
			Console.WriteLine("Nitro in use");
		}

	}
}
