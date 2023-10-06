namespace Builder_pattern
{
	class CBuilderNormal: IBuilder
	{
		CProduct _car = new CProduct();

		public void BuildEngine()
		{
			_car.PutEngine(new EngineBasic());
		}

		public void BuildWheels()
		{
			_car.PutWheels(new WheelsNormal());
		}

		public void BuildChasis()
		{
			_car.PutChasis(new ChasisBaisc());
		}

		public CProduct GetProduct()
		{
			return _car;
		}

	}
}
