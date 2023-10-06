using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_pattern
{
	class Component<T>: IComponent<T>
	{
		public T name { get; set; }


		public Component(T name)
		{
			this.name = name;
		}


		public void Adding(IComponent<T> elem)
		{
			Console.WriteLine("Only centered in composites not components");
		}


		public IComponent<T> Delete(T elem)
		{
			Console.WriteLine("Cant be eliminate directly");
			return this;
		}


		public IComponent<T> Search(T elem)
		{
			if (elem.Equals(name))
				return this;
			else
				return null;
		}


		public string Show(int deep)
		{
			//Put - depends on how deep we are in the herarchy
			return new string('-', deep) + name + "\n\r";
		}

	}

}
