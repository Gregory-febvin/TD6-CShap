using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD6
{
    internal abstract class Pokemon
    {
        protected string name;
        protected double poid;

        public Pokemon(string name, double poid)
        {
            this.name = name;
            this.poid = poid;
        }

        public abstract void affiche();
    }

    internal class terestre : Pokemon
    {
        private double taille;
        private int nb_patte;
        private double speed;
        private double distance;
        private int time;

        public terestre(string name, double poid, double taille, int nb_patte, int time) : base(name, poid)
        {
            this.taille = taille;
            this.nb_patte = nb_patte;
            speed = nb_patte * taille * 3;
            speed = Math.Round(speed, 2);
            this.time = time;
            this.distance = Math.Round(speed / 60 * time, 2);
        }

        public override void affiche()
        {
            Console.WriteLine($"Je suis le pokemon {name} !");
            Console.WriteLine($"Mon poids est de {poid} kg");
            Console.WriteLine($"Je possède {nb_patte} pattes");
            Console.WriteLine($"Ma taille est de {taille} m et ma vitesse {speed} km/h");
            Console.WriteLine($"J'ai marché {distance} km pendant {time} minutes\n");
        }
    }

    internal class marin : Pokemon
    {
        private int nb_nageoire;
        private double speed;
        private double distance;
        private int time;

        public marin(string name, double poid, int nb_nageoire, int time) : base(name, poid)
        {
            this.nb_nageoire = nb_nageoire;
            speed = poid / 25 * nb_nageoire;
            speed = Math.Round(speed, 2);
            this.time = time;
            this.distance = Math.Round(speed / 60 * time, 2);
        }

        public override void affiche()
        {
            Console.WriteLine($"Je suis le pokemon {name} !");
            Console.WriteLine($"Mon poids est de {poid} kg");
            Console.WriteLine($"Je possède {nb_nageoire} nageoires");
            Console.WriteLine($"Ma vitesse est de {speed} km/h");
            Console.WriteLine($"J'ai nagé {distance} km pendant {time} minutes\n");
        }
    }
}
