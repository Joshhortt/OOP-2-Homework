using System;

namespace _02.Interfaces
{
	public partial class Animal : IRun
    {
        public void Run()
        {
            Console.WriteLine("Animals also run");
        }
    }
}
