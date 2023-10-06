using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_pattern
{
	class CAdminPrototypes
	{

		Dictionary<string, IPrototype> _prototypes = new Dictionary<string, IPrototype>(); //Puede ser un diccionario o puede ser cualquier otra cosa


		public CAdminPrototypes()
		{
			CPerson modelPerson = new CPerson("Citizen", 18);
			_prototypes.Add("Person", modelPerson);

			CValues modelValues = new CValues(1);//Guardamos una instancia del contructor costoso y luego hacemos clones usando el constructor facil
			_prototypes.Add("Values", modelValues);
		}


		//Puedes agregar otros prototypes mas alla de los que se crean con el contructor
		public void AddPrototype(string key, IPrototype prototype)
		{
			_prototypes.Add(key, prototype);
		}

		public object GetPrototype(string key)
		{
			return _prototypes[key].Clone();
		}


	}
}
