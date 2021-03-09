using System;

namespace _02.Interfaces
{
	public class Person : IRun
    {
        public string SpeaksThisLanguage { get; set; }
        public int BiPedalism { get; set; }

        public void Run()
        {
            Console.WriteLine("Humans also run ");
        }
    }
}
