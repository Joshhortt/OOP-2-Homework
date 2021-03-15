// HOMEWORK - 08 - Mini-Project - Manager Details (Access Modifiers; Abstract Classes; Method Overriding)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerData
{
	class Program
    {
        static void Main(string[] args)
        {
            Manager data = new Manager();
            data.GetEmpData();
            data.DisplayEmpData();
            Console.ReadLine();
        }
    }
}

