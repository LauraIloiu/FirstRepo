using System;
using System.Collections.Generic;
using System.Text;

namespace FirstOOP
{
    public class Human : IRun
    {
        public void Run()
        {
            Console.WriteLine("I am human and I run");
        }
    }
}
