using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata40
{
    public class Program
    {
        public static void Main()
        {

        }
        public static string CatMouse(string x)
        {
            // Your code here...
            var characterslength = x.ToCharArray().Length - 2;
            return characterslength > 3 ? "Escaped!" : "Caught!";
        }
    }
}
