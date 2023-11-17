using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Potion
    {
        public string Type { get; private set; }
        public int BonusDegats { get; private set; }
        public double ReductDegats { get; private set; }

        public Potion(string type, int bonus, double reduction)
        {
            Type = type;
            BonusDegats = bonus;
            ReductDegats = reduction;
        }
    }
}
