using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_pattern
{
	class Composite<T>: IComponent<T>
	{

		List<IComponent<T>> elements;
		public T name{ get; set; }


		public Composite(T name)
		{
			this.name = name;
			elements = new List<IComponent<T>>();
		}


		public void Adding(IComponent<T> elem)
		{
			elements.Add(elem);
		}


		public IComponent<T> Delete(T elem)
		{
			IComponent<T> element = this.Search(elem);

			if(element != null)
				(this as Composite<T>).elements.Remove(element);

			return this;

		}


		public IComponent<T> Search(T elem)
		{
			//Check if we are our self
			if (name.Equals(elem))
				return this;

			//if we are not search in our elements
			IComponent<T> found = null;

			foreach (IComponent<T> item in elements)
			{

				found = item.Search(elem);

				if (found != null)
					break;

			}

			return found;

		}


		public string Show(int deep)
		{

			StringBuilder infoElement = new StringBuilder(new String('-', deep));

			infoElement.Append("Composite: " + name + " element :" + elements.Count +"\r\n");

			foreach (IComponent<T> elem in elements)
				infoElement.Append(elem.Show(deep + 1));

			return infoElement.ToString();

		}

	}
}
