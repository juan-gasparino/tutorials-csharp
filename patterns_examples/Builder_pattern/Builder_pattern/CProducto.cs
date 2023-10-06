using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
	class CProduct
	{
		IEngine _engine;
		IChasis _chasis;
		IWheels _wheels;

		public void PutEngine(IEngine engine)
		{
			_engine = engine;
			Console.WriteLine("Se ha colocado el motor:{0}", _engine.specifications());
		}

		public void PutChasis(IChasis chasis)
		{
			_chasis = chasis;
			Console.WriteLine("Se ha colocado el chasis:{0}", _chasis.characteristics());
		}

		public void PutWheels(IWheels wheels)
		{
			_wheels = wheels;
			Console.WriteLine("Se ha colocado las llantas:{0}", _wheels.information());
		}

		public void ShowCar()
		{
			Console.WriteLine("Tu coche tiene {0}, {1}, {2}", _engine.specifications(), _chasis.characteristics(), _wheels.information());
		}

	}
}
