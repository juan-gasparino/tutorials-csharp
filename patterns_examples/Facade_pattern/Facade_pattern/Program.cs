using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Subsytems;

namespace Facade_pattern
{
	class Program
	{
		static void Main(string[] args)
		{
			CFacade facade = new CFacade();
			facade.Buy();
			facade.Buy();
			facade.Buy();
			facade.Buy();
		}

	}

}