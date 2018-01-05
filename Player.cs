using oyun.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oyun.Models
{
    public delegate void HealthHandle();
   public abstract class Player 
    {
         public  int Power { get; set; }
        public CharacterType Type;
        public string Name{ get; set; }
        public  int _health { get; set; }
  public int Health
        {
            get { return _health; }
            set
            {
                _health = value;
                if (_health <= 0)
                    OnDeath();
            }
        }
        public event HealthHandle OnDeath;
        public virtual int Attack(int r)
        {
            int x = 2;
            if (r < 8)
                x = 0;
            else if (r < 17)
                x = 1;
            return Power * x;
        }

        public virtual void HealthDecrease(int hit)
        {
            this.Health -= hit;
        }

    }
}
