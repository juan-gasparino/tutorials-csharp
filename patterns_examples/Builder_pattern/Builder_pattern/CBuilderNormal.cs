namespace Builder_pattern
{
	class CBuilderSport: IBuilder
	{
		CProduct _car = new CProduct();

		public void BuildEngine()
		{
			_car.PutEngine(new EngineBig());
		}

		public void BuildWheels()
		{
			_car.PutWheels(new WheelsSuper());
		}

		public void BuildChasis()
		{
			_car.PutChasis(new ChasisCarbonFiber());
		}

		public CProduct GetProduct()
		{
			return _car;
		}

	}
}
