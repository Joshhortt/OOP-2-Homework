using System;


namespace AbstractClass
{
	// Class IPhoneX with override methdos and one public void method, also inherits from Class AppleSmartPhone
	class IPhoneX : AppleSmartPhone 
	{
		// override method
		public override void SmartModel()
		{
			Console.WriteLine("Model: The model of this Phone is iPhone-X.");
		}

		// method
		public void LaunchDate()
		{
			Console.WriteLine("Launch Date: This Phone was launched on November 3, 2017.");
		}

		// override method
		public override void OS()
		{
			Console.WriteLine("OS: Macintosh.");
		}

		// override method
		public override void AppStore()
		{
			Console.WriteLine("Apple AppStore.");
		}
	}
}