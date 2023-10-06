using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_pattern
{
	class CCar: IPrototype
	{

		string _model;
		int _price;

		public string model { get { return _model; } set { _model = value; } }
		public int price { get { return _price; } set { _price = value; } }


		public CCar(string model, int price)
		{
			_model = model;
			_price = price;
		}


		public override string ToString()
		{
			return String.Format("{0}, {1}", _model, _price);
		}


		public object Clone()
		{
			CCar clone = new CCar(_model, _price);
			return clone;
		}


	}
}
