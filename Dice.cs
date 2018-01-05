using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oyun.Static
{
    public static class Dice
    {
        private static Random rand = new Random();
        private static int r;

        public static int Roll()
        {
            r = rand.Next(0, 20);
            return r;
        }
    }
}
