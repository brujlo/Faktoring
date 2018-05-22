using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoring
{
    public class Bube
    {
        public static IBugs GetInsect(string InsectType)
        {
            switch (InsectType)
            {
                case "Ant":
                    return new Ant();
                case "Bee":
                    return new Bee();
                case "Spider":
                default:
                    //return new Spider("8");
                    return new Spider();
            }
        }
    }
}
