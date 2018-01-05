using oyun.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oyun.Models
{
    class Mage :Player
    {

        public Mage()
        {
            Type = CharacterType.Warrior;
            Health = 70;
            Power = 50;
        }
    }
}
