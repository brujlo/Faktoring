using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoring
{
    public class Spider : IBugs
    {
        private string brojNogu;

        public Spider(string brNg) { brojNogu = brNg; }
        public Spider() {}

        public void Insect()
        {
            if (brojNogu is null)
                Console.WriteLine("Spider make a web, not www, brrrrr");
            else
                Console.WriteLine("Spider make a web, not www, brrrrr" + " " + "Ima {0} nogu");
        }
    }
}
