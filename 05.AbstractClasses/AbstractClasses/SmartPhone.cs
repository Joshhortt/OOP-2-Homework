// 05 - HOMEWORK - Abstract Classes part 1
// Create Console Application with an Abstract Class.
using AbstractClasses;
using System;


namespace AbstractClass
{
	//Abstract Class SmartPhone with only abstract methods in it, inherits also from Interface  
	abstract class SmartPhone : ISmartPhone
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
			Console.WriteLine("No Virtual Assistant.");
		}
	}
}