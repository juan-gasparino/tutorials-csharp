using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_pattern
{
	class Program
	{
		static void Main(string[] args)
		{
			CProxy.ISubject myProxy = new CProxy.SingleProxy();

			myProxy.Petition(1);
			Console.WriteLine("--------");

			myProxy.Petition(2);
			Console.WriteLine("--------");

			CProxy.ISubject myProxyS = new CProxy.SafeProxy();

			myProxyS.Petition(1);
			Console.WriteLine("--------");

			myProxyS.Petition(2);
			Console.WriteLine("--------");
		}

	}

}