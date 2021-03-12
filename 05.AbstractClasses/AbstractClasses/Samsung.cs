// 05 - HOMEWORK - Abstract Classes part 1
// Create Console Application with an Abstract Class.

using System;

namespace AbstractClass
{
    // Class Samsung with only override methdos, also inherits from Class Smartphone
    class Samsung : SmartPhone  
    {
        // override method
        public override void SmartModel()
        {
            Console.WriteLine("Model: The model of this Phone is Samsung Z-Fold.");
        }
        // method
        public void LaunchDate()
        {
            Console.WriteLine("Launch Date: This Phone was launched on September 6, 2019.");
        }

        // override method
        public override void OS()
        {
            Console.WriteLine("OS: 4G: Qualcomm Snapdragon.");
        }

        // override method
        public override void AppStore()
        {
            Console.WriteLine("AppStore: Google Play Store.");
        }
    }
}