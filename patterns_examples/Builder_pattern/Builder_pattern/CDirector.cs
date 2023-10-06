using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
	class CDirector
	{
		public void Build(IBuilder build)
		{
			//Aqui el director indica los pasos para hacer la construccion
			//pero el constructor es el que se encarga de construir segun
			//especificaciones
			build.BuildEngine();
			build.BuildChasis();
			build.BuildWheels();
		}
	}
}
