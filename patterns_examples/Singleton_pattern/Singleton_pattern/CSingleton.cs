using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_pattern
{
	class CSingleton
	{

		static CSingleton _instance;

		string _name;
		int _age;

		CSingleton()
		{
			_name = "";
			_age = 0;
		}

		public static CSingleton GetInstance()
		{
			//verificamos que haya solo una instancia
			if(_instance == null)
			{
				//Si no exite, instanciamos
				_instance = new CSingleton();
				Console.WriteLine("Instanciado por primera vez");
			}
			return _instance;
		}

		public override string ToString()
		{
			return String.Format("La persona {0}, tiene {1} de edad", _name, _age);
		}

		public void setData(string name, int age)
		{
			_name=name;
			_age = age;
		}

		public void SomeProcess()
		{
			Console.WriteLine("{0} esta trabajando en algo", _name);
		}

	}
}
