using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    using System;

    namespace RPG
    {
        public class Partie
        {
            private Joueur joueur;
            private Marchand marchand;

            public Partie(string pseudo, string team)
            {
                joueur = new Joueur(pseudo, team, 200,50,100) ;
                marchand = new Marchand();
            }

            internal void CommencerAventure()
            {
                Console.WriteLine("Début de l'aventure !");
                Console.WriteLine($"Bienvenue, guerrier {joueur.Pseudo} de l'équipe {joueur.Team}.");

                for (int i = 1; i <= 3; i++)
                {
                    string chemin = $"Chemin {i}";
                    Monstre monstre = CreerMonstre(chemin);
                    if (monstre != null)
                    {
                        Console.WriteLine($"Vous êtes sur le {chemin} et vous affrontez {monstre.Nom} ({monstre.Type}).");


                        Potion potion = marchand.ProposerPotion(monstre);
                        if (potion != null)
                        {
                            object value = Joueur.UtiliserPotion(potion, monstre.Type);
                            Console.WriteLine("Choisissez votre potion pour ce combat !");
                        }

                        Joueur joueur1 = new Joueur("pseudo","team",200,50,100);
                        Monstre monstre1 = new Monstre();

                        joueur1.AffronterMonstre(monstre);

                        if (joueur1.PointsDeVie <= 0)
                        {
                            Console.WriteLine("Vous avez été vaincu !");
                            return;
                        }
                    }
                }
            }


            private Monstre CreerMonstre(string chemin)
            {
                // Crée un monstre en fonction du chemin choisi
                if (chemin == "Chemin 1")
                {
                    return new Aquadox();
                }
                else if (chemin == "Chemin 2")
                {
                    return new Firelost();
                }
                else if (chemin == "Chemin 3")
                {
                    return new Voltek();
                }

                return null;
            }
        }
    }
}
