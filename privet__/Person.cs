using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privet__
{
    //1
    internal class Person
    {

        public Person() { }
        private int Age = 0;
        public void SetAge(int Age)
        {
            this.Age = Age;
        }
        public int GetAge { get { return this.Age; } }
    }

}
