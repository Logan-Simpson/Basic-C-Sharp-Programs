using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newClass226
{
    public class mathClass
        {
            public int Add(int input)
            {
                int result = input + 20;
                return result;
            }
            public int Add(decimal input)
            {
                decimal result = input + 50;
                int resultfinal = Convert.ToInt32(result);
                return resultfinal;
            }
            public int Add(string input)
            {
                int result = Convert.ToInt32(input);
                result = result + 5;
                return result;
            }
        }
    }


