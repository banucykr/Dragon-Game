using oyun.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oyun.Models
{
     public class Warrior :Player
    {
        public Warrior()
        {
            Type = CharacterType.Warrior;
            Health = 100;
            Power = 50;
        }
    }
}
