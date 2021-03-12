// 05 - HOMEWORK - Abstract Classes part 1
// Create Console Application with an Abstract Class, that has an Interface applied to it. 
// When instantiating the child class store it using the interface type.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
	// Main Class  
	class Program 
    {
        static void Main(string[] args)
        {
            // new iphone Instance, also calling methods
            IPhoneX iphone = new IPhoneX();
            iphone.CallSmart();
            iphone.SmartModel();
            iphone.LaunchDate();
            iphone.OS();
            iphone.AppStore();
            iphone.VirtualAssistant();

            // new samsung Instance, also calling methods
            Samsung samsungZ = new Samsung();
            samsungZ.CallSmart();
            samsungZ.SmartModel();
            samsungZ.LaunchDate();
            samsungZ.OS();
            samsungZ.AppStore();
            samsungZ.VirtualAssistant();
          
   
            Console.ReadLine();
        }
	}
}