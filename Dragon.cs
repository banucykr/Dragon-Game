using oyun.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oyun.Models
{
    public class Dragon : Player
    {
        public Dragon(string name)
        {
            Name = name;
            Type = CharacterType.Dragon;
            Health = 500;
            Power = 25;

        }
        public override int Attack(int r)
        {
            int x = 5;
            if (r < 15)
                x = 0;
            else if (r < 19)
                x = 1;
            return Power * x;
        }
    }
}
