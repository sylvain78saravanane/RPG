using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Marchand
    {
        public Potion ProposerPotion(Monstre monstre)
        {
            if (monstre is Aquadox)
            {
                return new Potion("Potion EAU", 100, 0.5);
            }
            else if (monstre is Firelost)
            {
                return new Potion("Potion FEU", 100, 0.5);
            }
            else if (monstre is Voltek)
            {
                return new Potion("Potion FOUDRE", 100, 0.5);
            }
            else
            {
                throw new ArgumentException("Monstre non reconnu");
            }
        }
    }

}
