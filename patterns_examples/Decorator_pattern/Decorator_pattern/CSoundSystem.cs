using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
	class CSoundSystem : IComponent
	{

		private IComponent _decoredTo;


		public CSoundSystem(IComponent decoredTo)
		{
			_decoredTo = decoredTo;
		}


		public override string ToString()
		{
			return "Sound system 350XZ\r\n" + _decoredTo.ToString();
		}


		public double Cost()
		{
			return _decoredTo.Cost() + 10000;
		}


		public string Works()
		{
			return _decoredTo.Works() + ", Sound ready";
		}

	}
}