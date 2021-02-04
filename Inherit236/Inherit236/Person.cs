using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit236
{
    public class Person
    {
        private string FirstName;
        private string LastName;

        public Person(string First, string Last)
        {
            FirstName = First;
            LastName = Last;
        }

        public string Name => $"{ FirstName } {LastName }";
        
    }
}
