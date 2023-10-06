using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_pattern
{
	class CValues: IPrototype
	{
		int _m;
		float _sumatory;

		public int m { get => _m; set => _m = value; }
		public float sumatory { get => _sumatory; set => _sumatory = value; }

		public CValues()
		{

		}

		//Constructor costoso
		public CValues(int m)
		{
			_m = m;

			for(int i = 0; i < 90; i++)
			{
				_sumatory += (float)Math.Sin(i * 0.0175);
			}

		}

		public override string ToString()
		{
			return String.Format("{0}", _sumatory * _m);
		}

		public object Clone()
		{

			CValues clone = new CValues();
			clone.m = _m;
			clone.sumatory = _sumatory;

			return clone;
		}

	}
}
