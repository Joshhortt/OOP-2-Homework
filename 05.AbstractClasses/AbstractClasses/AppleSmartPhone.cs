using AbstractClasses;
using System;


namespace AbstractClass
{
    //Abstract Class AppleSmartPhone with only abstract methods in it, inherits also from Interface 
    abstract class AppleSmartPhone : ISmartPhone

    {
        public void CallSmart()
        {
            Console.WriteLine("Call Smart Method: This method provides Calling features.");
        }

        public abstract void SmartModel();
        public abstract void OS();
        public abstract void AppStore();

        // Interface method
        public void VirtualAssistant()
		{
			Console.WriteLine("Virtual Assistant 'Siri'.\n");
		}
	}
}