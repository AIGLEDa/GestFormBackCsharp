using System;
using System.Collections.Generic;

namespace GestFormAppli
{
    class Program
    {
        static void Main(string[] args)
        {
            //Créer une liste de type float avec le nom ListRandom
            List<float> ListRandom = new List<float>();

            //Initialiser la valeur qui comprendra le nombre à zero(0)
            float valueBetween1000AndNegative1000 = 0;

            //Boucle for de 20 éléments. La boucle commence à l'indice 0 et fini à 19.
            for (int i = 0; i < 20; i++)
            {
                //créer un élément aléatoire
                var rand = new Random();

                //Next permet de varier le nombre de 0 à 2000 (il y a un décalage donc c'est 2001 est pas 2000.
                valueBetween1000AndNegative1000 = rand.Next(0, 2001);

                //La fonction return un float. Le paramètre et la valeur aléatoire.
                float number = GetThevalue(valueBetween1000AndNegative1000);

                //J'ajoute le number, sa valeur à la liste.
                ListRandom.Add(number);
                
            }

            //foreache recherche tout les éléments d'une liste, ici ListRandom.
            foreach (var item in ListRandom)
            {
                Console.WriteLine($"le nombre est : {item}");

                //le modulo de la valeur avec 3 
                float valueResultat3 = item % 3;

                //le modulo de la valeur avec 5
                float valueResultat5 = item %5;
          
                Console.WriteLine(valueResultat5);
                Console.WriteLine(valueResultat3);

                //si le modulo == 0 donc c'est divisible par 3
                if (valueResultat3 == 0)
                {
                    //affiche Gest en cas de réussite de la condition
                    Console.WriteLine("Gest");
                }

                //si le modulo == 0 donc c'est divisible par 5
                if (valueResultat5 ==0)
                {
                    //affiche Forme en cas de réussite de la condition
                    Console.WriteLine("Forme");
                }
                
                // si la condition n'est pas égal à zero pour le modulo de 3 et si la condition n'est pas égal
                //à zéro pour le modulo de 5
                if(valueResultat3 != 0 && valueResultat5 != 0)
                {
                    //affiche le nombre
                    Console.WriteLine(item);
                }

                //si les deux conditons sont bonne
                if(valueResultat3 == 0 && valueResultat5 == 0)
                {
                    //alors affiche GestForme
                    Console.WriteLine("GestForme");
                }
            }
        }

        /// <summary>
        /// Gets the value
        /// </summary>
        /// <param name="x">The name</param>
        /// <returns>the value</returns>
        public static float GetThevalue(float x)
        {
            float valueNegativeForList = 0;

            //si valeur supérieur à 100 donc valeur négative
            if(x > 1000)
            {
                valueNegativeForList = x - 2000;
            }
            else
            {
                valueNegativeForList = x;
            }

            //retourne la valeur pour la méthode
            return valueNegativeForList;
        }
    }
}
