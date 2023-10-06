using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_pattern
{
	public class CProxy
	{
		public interface ISubject
		{
			void Petition(int option);
		}

		public class SingleProxy: ISubject
		{
			private CKitchen _kitchen = null;

			public void Petition(int option)
			{
				if(_kitchen == null)
				{
					Console.WriteLine("Activating subject");
					_kitchen = new CKitchen();
				}

				if (option == 1)
					_kitchen.SecretRecipe();
				if (option == 2)
					_kitchen.Cooking(5);

			}

		}

		public class SafeProxy : ISubject
		{
			private CKitchen _kitchen = null;

			public void Petition(int option)
			{

				string password;

				Console.WriteLine("Give me password:");
				password = Console.ReadLine();

				if(password == "asdf")
				{
					if(_kitchen == null)
					{
						Console.WriteLine("Activate subject");
						_kitchen = new CKitchen();
					}

					if (option == 1)
						_kitchen.SecretRecipe();
					if (option == 2)
						_kitchen.Cooking(5);

				}
				else
				{
					Console.WriteLine("Access denied");
				}

			}

		}

		private class CKitchen
		{
			public void SecretRecipe()
			{
				Console.WriteLine("Bread");
				Console.WriteLine("Olive oil");
				Console.WriteLine("Jam");
				Console.WriteLine("Chess");
			}

			public void Cooking(int recipes)
			{
				Console.WriteLine("Cooking {0} recipes", recipes);
			}
		}

	}
}
