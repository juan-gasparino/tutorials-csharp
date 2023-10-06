using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_pattern
{
	interface IComponent<T>
	{
		T name { get; set; }
		void Adding(IComponent<T> elem);
		IComponent<T> Delete(T elem);
		IComponent<T> Search(T elem);
		string Show(int Deep);
	}
}
