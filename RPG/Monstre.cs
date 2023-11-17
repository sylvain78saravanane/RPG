using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Monstre
    {
        public string Nom { get; set; }
        public string Type { get; set; }
        public int PointsDeVieMonstre { get; set; }
        public int PointsDAttaque { get; set; }
        public int Degats { get;  set; }


        public virtual void Attaquer(Joueur joueur)
        {
            // Logique d'attaque par défaut
        }
    }

    public class Aquadox : Monstre
    {
        public Aquadox()
        {
            Nom = "Aquadox";
            Type = "EAU";
            PointsDeVieMonstre = 500;
            PointsDAttaque = 10;
        }

        public override void Attaquer(Joueur joueur)
        {
            Console.WriteLine("Aquadox vous attaque!");

            Console.WriteLine("Choisissez une potion pour vous défendre :");
            Console.WriteLine("1. Potion FOUDRE");
            Console.WriteLine("2. Potion FEU");
            Console.WriteLine("3. Potion EAU");
            // Laissez le joueur choisir une potion
            string choixPotion = Console.ReadLine();

            if (!string.IsNullOrEmpty(choixPotion))
            {
                switch (choixPotion)
                {
                    case "1":
                        joueur.PointsDeVie -= (int)(PointsDAttaque * 4);
                        Console.WriteLine("Vous avez utilisé une Potion FOUDRE pour réduire les dégâts!");
                        break;
                    case "2":
                        joueur.PointsDeVie -= (int)(PointsDAttaque * 0.5);
                        Console.WriteLine("Vous avez utilisé une Potion FEU pour réduire les dégâts!");
                        break;
                    case "3":
                        joueur.PointsDeVie -= (int)(PointsDAttaque * 1);
                        Console.WriteLine("Vous avez utilisé une Potion EAU pour réduire les dégâts!");
                        break;

                    default:
                        joueur.PointsDeVie -= PointsDAttaque;
                        Console.WriteLine("Vous n'avez pas utilisé de potion. Les dégâts sont normaux.");
                        break;
                }
            }
            else
            {
                // Le joueur n'a pas fait de choix de potion, mettez en œuvre une logique par défaut
                joueur.PointsDeVie -= PointsDAttaque;
                Console.WriteLine("Vous n'avez pas choisi de potion. Les dégâts sont normaux.");
            }
        }

    }

    public class Firelost : Monstre
    {
        public Firelost()
        {
            Nom = "Firelost";
            Type = "FEU";
            PointsDeVieMonstre = 500;
            PointsDAttaque = 10;
        }

        public override void Attaquer(Joueur joueur)
        {
            Console.WriteLine("Firelost vous attaque!");

            Console.WriteLine("Choisissez une potion pour vous défendre :");
            Console.WriteLine("1. Potion FOUDRE");
            Console.WriteLine("2. Potion FEU");
            Console.WriteLine("3. Potion EAU");
            // Laissez le joueur choisir une potion
            string choixPotion = Console.ReadLine();

            if (!string.IsNullOrEmpty(choixPotion))
            {
                switch (choixPotion)
                {
                    case "1":
                        joueur.PointsDeVie -= (int)(PointsDAttaque * 0.5);
                        Console.WriteLine("Vous avez utilisé une Potion FOUDRE pour réduire les dégâts!");
                        break;
                    case "2":
                        joueur.PointsDeVie -= (int)(PointsDAttaque * 1);
                        Console.WriteLine("Vous avez utilisé une Potion FEU pour réduire les dégâts!");
                        break;
                    case "3":
                        joueur.PointsDeVie -= (int)(PointsDAttaque * 4);
                        Console.WriteLine("Vous avez utilisé une Potion EAU pour réduire les dégâts!");
                        break;

                    default:
                        joueur.PointsDeVie -= PointsDAttaque;
                        Console.WriteLine("Vous n'avez pas utilisé de potion. Les dégâts sont normaux.");
                        break;
                }
            }
            else
            {
                // Le joueur n'a pas fait de choix de potion, mettez en œuvre une logique par défaut
                joueur.PointsDeVie -= PointsDAttaque;
                Console.WriteLine("Vous n'avez pas choisi de potion. Les dégâts sont normaux.");
            }
        }

    }

    public class Voltek : Monstre
    {
        public Voltek()
        {
            Nom = "Voltek";
            Type = "FOUDRE";
            PointsDeVieMonstre = 500;
            PointsDAttaque = 10;
        }

        public override void Attaquer(Joueur joueur)
        {
            Console.WriteLine("Voltek vous attaque!");

            Console.WriteLine("Choisissez une potion pour vous défendre :");
            Console.WriteLine("1. Potion FOUDRE");
            Console.WriteLine("2. Potion FEU");
            Console.WriteLine("3. Potion EAU");

            string choixPotion = Console.ReadLine();

            if (!string.IsNullOrEmpty(choixPotion))
            {
                switch (choixPotion)
                {
                    case "1":
                        joueur.PointsDeVie -= (int)(PointsDAttaque * 1);
                        Console.WriteLine("Vous avez utilisé une Potion FOUDRE pour réduire les dégâts!");
                        break;
                    case "2":
                        joueur.PointsDeVie -= (int)(PointsDAttaque * 4);
                        Console.WriteLine("Vous avez utilisé une Potion FEU pour réduire les dégâts!");
                        break;
                    case "3":
                        joueur.PointsDeVie -= (int)(PointsDAttaque * 0.5);
                        Console.WriteLine("Vous avez utilisé une Potion EAU pour réduire les dégâts!");
                        break;

                    default:
                        joueur.PointsDeVie -= PointsDAttaque;
                        Console.WriteLine("Vous n'avez pas utilisé de potion. Les dégâts sont normaux.");
                        break;
                }
            }
            else
            {
                // Le joueur n'a pas fait de choix de potion, mettez en œuvre une logique par défaut
                joueur.PointsDeVie -= PointsDAttaque;
                Console.WriteLine("Vous n'avez pas choisi de potion. Les dégâts sont normaux.");
            }
        }
    }
}
