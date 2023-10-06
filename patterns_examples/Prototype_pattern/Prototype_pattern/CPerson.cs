using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_pattern
{
	class CPerson: IPrototype
	{

		string _name;
		int _age;

		public string name { get { return _name; } set { _name = value; } }
		public int age { get { return _age; } set { _age = value; } }


		public CPerson(string name, int age)
		{
			_name = name;
			_age = age;
		}


		public override string ToString()
		{
			return String.Format("{0}, {1}", _name, _age);
		}


		public object Clone()
		{
			CPerson clone = new CPerson(_name, _age);
			return clone;
		}


	}
}
