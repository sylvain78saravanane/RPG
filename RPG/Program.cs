using RPG.RPG;
using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            CommencerJeu();
            Console.WriteLine("Bienvenue sur RPG-Monster by SARAVANANE Sylvain");
        }

        static void CommencerJeu()
        {
            Partie partie = CreerPartie();
            partie.CommencerAventure();
        }

        static Partie CreerPartie()
        {
            Console.WriteLine("Bienvenue ! Entrez votre pseudo :");
            string pseudo = Console.ReadLine();

            Console.WriteLine("Entrez le nom de votre équipe :");
            string team = Console.ReadLine();

            return new Partie(pseudo, team);
        }
    }
}


  