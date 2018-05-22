using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoring
{
    class Bugs
    {
        static void Main(string[] args)
        {
            IBugs ins = Bube.GetInsect("Spider");
            ins.Insect();

            Console.ReadKey();

        }
    }
}
