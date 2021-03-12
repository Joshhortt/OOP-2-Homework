using System;


namespace AbstractClass
{
	class IPhoneX : Phone
	{
		public override void Model()
		{
			Console.WriteLine("Model: The model of this Phone is iPhone-X");
		}

		public void LaunchDate()
		{
			Console.WriteLine("Launch Date: This Phone was launched on November 3, 2017");
		}
	}
}