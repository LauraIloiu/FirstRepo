using System;
using System.Collections.Generic;
using System.Text;

namespace SecondOOP
{
    public class Mammal
    {
        private string name;
        private int feetNo;
        public void Eat()
        {
            Console.WriteLine("Mammal - Eat");
        }

        public void Talk()
        {
            Console.WriteLine("Mammal - Talk");
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int FeetNo
        {
            get { return feetNo; }
            set { feetNo = value; }
        }
    }
}
