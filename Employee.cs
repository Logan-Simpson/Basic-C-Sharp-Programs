using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit236
{
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }

        public void Quit()
        {
            Console.WriteLine("I quit!");
        }

    }
   
    
}
