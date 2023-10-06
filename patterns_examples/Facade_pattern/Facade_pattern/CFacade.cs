using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsytems
{
	class CFacade
	{
		//La facha anida todas las clases haciendo que desde el cliente solo me tenga que conectar a metodo que esta en la fachada
		CSystemBuy buy = new CSystemBuy();
		CSubsystemWarehouse warehouse = new CSubsystemWarehouse();
		CSubSystemSend send = new CSubSystemSend();

		public void Buy()
		{
			if (buy.Buy())
			{
				if (warehouse.DispatchProduct())
				{
					send.SendPackage();
				}
			}
		}

	}
}
