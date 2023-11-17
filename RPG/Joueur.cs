using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Joueur
    {
        public string Pseudo { get; set; }
        public string Team { get; set; }
        public int PointsDeVie { get; set; }
        public int PointsDAttaque { get; set; }
        public int PotionVie { get; set; }

        public Joueur(string pseudo, string team, int PDV, int Attack, int potionVie)
        {
            Pseudo = pseudo;
            Team = team;
            PointsDeVie = PDV;
            PointsDAttaque = Attack;
            PotionVie = potionVie;
        }

        public void UtiliserPotionVie()
        {
            if (PointsDeVie <= 100)
            {
                Console.WriteLine("Vous utilisez votre potion de vie.");
                PointsDeVie += PotionVie;
                Console.WriteLine("Vos points de vie ont été restaurés !");
            }
            else
            {
                Console.WriteLine("Vous n'avez pas besoin de votre potion de vie pour l'instant !");
            }
        }

        public void PotionDeVie()
        {
            if (this.PointsDeVie <= 100)
            {
                Console.WriteLine("Voulez-vous utiliser votre potion de vie ? O ou N");
                string reponse = Console.ReadLine();

                if (reponse == "O")
                {
                    this.UtiliserPotionVie();
                    Console.WriteLine($"{Pseudo} tu as utilisé la potion de vie !");
                }
                else if (reponse == "N")
                {
                    Console.WriteLine($"Continuons {Pseudo}");
                }
            }
        }


        internal void UtiliserPotion(Potion potion, string typeMonstre, Monstre monstre1)
        {
            // Logique pour utiliser la potion en fonction du type de monstre
            if (potion.Type == "EAU")
            {
                if (typeMonstre == "FEU")
                {
                    int degatsSupplementaires = (int)(monstre1.PointsDAttaque * 0.15);
                    int nouveauxDegats = monstre1.Degats + degatsSupplementaires;
                }
            }
        }

        internal void AffronterMonstre(Monstre monstre)
        {
            Console.WriteLine($"Vous affrontez {monstre.Nom} ({monstre.Type}) !");

            while (PointsDeVie > 0 && monstre.PointsDeVieMonstre > 0)
            {
                Console.WriteLine($"Vous attaquez {monstre.Nom} !");
                monstre.PointsDeVieMonstre -= PointsDAttaque;


                if (monstre.PointsDeVieMonstre <= 0)
                {
                    Console.WriteLine($"Vous avez vaincu {monstre.Nom} !");
                    break;
                }

                Console.WriteLine($"{monstre.Nom} vous attaque !");
                PointsDeVie -= monstre.PointsDAttaque;

                if (PointsDeVie <= 0)
                {
                    Console.WriteLine($"Vous avez été vaincu par {monstre.Nom} !");
                }
            }
        }

        internal static object UtiliserPotion(Potion potion, string type)
        {
            throw new NotImplementedException();
        }

        internal void CommencerAventure(Marchand marchand)
        {
            throw new NotImplementedException();
        }
    }
}