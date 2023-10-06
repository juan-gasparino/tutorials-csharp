using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
	class CSuspention : IComponent
	{

		private IComponent _decoredTo;


		public CSuspention(IComponent decoredTo)
		{
			_decoredTo = decoredTo;
		}


		public override string ToString()
		{
			return "New suspention working\r\n" + _decoredTo.ToString();
		}


		public double Cost()
		{
			return _decoredTo.Cost() + 50000;
		}


		public string Works()
		{
			return _decoredTo.Works() + ", Suspention up";
		}

	}
}