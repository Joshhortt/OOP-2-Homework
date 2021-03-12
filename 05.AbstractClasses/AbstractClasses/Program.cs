// 05 - HOMEWORK - Abstract Classes part 1
// Create Console Application with an Abstract Class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractClass
{
	abstract class Phone 
    {
        public void Call()
        {
            Console.WriteLine("Call Method: This method provides Calling features");
        }
        public abstract void Model();
    }

    class Program
    {
        static void Main(string[] args)
        {
            IPhoneX iphone = new IPhoneX();

            iphone.Call();
            iphone.Model();
            iphone.LaunchDate();

            Console.ReadLine();
        }
    }
}