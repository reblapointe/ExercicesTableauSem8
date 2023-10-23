using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ExercicesTableau
{
    internal class Program
    {
        static void Sem8Exercice1()
        {
            Console.WriteLine("Exercice 1");
            int[] lancers = { 5, 2, 1, 6, 5, 1, 3, 6, 3, 4 };
            Console.WriteLine(lancers[0]);
            Console.WriteLine(lancers[7]);
            //Console.WriteLine(lancers[87]);
            //Console.WriteLine(lancers[-1]);
        }

        static void Sem8Exercice2()
        {
            Console.WriteLine("Exercice 2");
            int[] fratries = { 5, 2, 1, 3, 3, 2, 1, 1, 1, 6, 4, 4 };
            fratries[7]++;
            for (int i = 0; i < fratries.Length; i++)
                Console.Write(i + ":" + fratries[i] + " ");

            int enfantsUniques = 0;
            for (int i = 0; i < fratries.Length; i++)
                if (fratries[i] == 1)
                    enfantsUniques++;
            Console.WriteLine($"Il y a {enfantsUniques} enfants uniques.");
        }

        static void Sem8Exercice3()
        {
            Console.WriteLine("Exercice 3.a");
            string[] noms = new string[5];
            for (int i = 0; i < noms.Length; i++)
            {
                Console.WriteLine($"Entrez le nom de l'étudiant #{i}");
                noms[i] = Console.ReadLine() ?? "";
            }
            Console.WriteLine("Voici les noms : ");
            for (int i = 0; i < noms.Length; i++)
                Console.Write(noms[i] + " ");

            Console.WriteLine();
            Console.WriteLine("Exercice 3.b");
            Console.WriteLine("Combien d'étudiants avez-vous?");
            _ = int.TryParse(Console.ReadLine(), out int n);
            string[] nomsB = new string[n];
            for (int i = 0; i < nomsB.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Entrez le nom de l'étudiant #{i}");
                    nomsB[i] = Console.ReadLine() ?? "";
                } while (nomsB[i] == ""); // Exercice 4
            }
            Console.WriteLine("Voici les noms : ");
            for (int i = 0; i < nomsB.Length; i++)
            {
                Console.Write(nomsB[i] + " ");
            }

            // Exercice 5
            Console.WriteLine();
            Console.WriteLine("Contient Bob? " + Sem8Exercice5A(nomsB));
            Console.WriteLine("Indice Eric? " + Sem8Exercice5B(nomsB));
            Console.WriteLine("Nombres de Philippe? " + Sem8Exercice5C(nomsB));

            Sem8Exercice5D(nomsB);
            for (int i = 0; i < nomsB.Length; i++)
            {
                Console.Write(nomsB[i] + " ");
            }
        }

        static bool Sem8Exercice5A(string[] noms)
        {
            for (int i = 0; i < noms.Length; i++)
                if (noms[i] == "Bob")
                    return true;
            return false;
        }


        static int Sem8Exercice5B(string[] noms)
        {
            for (int i = 0; i < noms.Length; i++)
                if (noms[i] == "Eric")
                    return i;
            return -1;
        }


        static int Sem8Exercice5C(string[] noms)
        {
            int nbPhilippes = 0;
            for (int i = 0; i < noms.Length; i++)
                if (noms[i] == "Philippe")
                    nbPhilippes++;
            return nbPhilippes;
        }


        static void Sem8Exercice5D(string[] noms)
        {
            for (int i = 0; i < noms.Length; i++)
                if (noms[i] == "Bob")
                    noms[i] = "Robert";
        }

        static string Sem8Exercice6A(string texte)
        {
            return texte.Replace('m', 'b').Replace('M', 'B').Replace('n', 'd').Replace('N', 'D');
        }

        static void Sem8Exercice6B(string texte)
        {
            texte = texte.ToUpper();
            for (int i = texte.Length - 1; i >= 0; i--)
                Console.Write(texte[i]);
            Console.WriteLine();
        }

        static void Sem10Exercice1()
        {
            int[] nombres = { 10, 0, 12, 16, 45, 1, 100, 98 };
            double[] racines = new double[nombres.Length];

            for (int i = 0; i < racines.Length; i++)
            {
                racines[i] = Math.Sqrt(nombres[i]);
            }
            Console.WriteLine(racines[nombres[1]]);

            Console.WriteLine("Type de nombres        : " + nombres.GetType());
            Console.WriteLine("Type de nombres.Length : " + nombres.Length.GetType());
            Console.WriteLine("Type de nombres[0]     : " + nombres[0].GetType());
            Console.WriteLine("Type de nombres        : " + racines.GetType());
            Console.WriteLine("Type de racines.Legth  : " + racines.Length.GetType());
            Console.WriteLine("Type de racines[0]     : " + racines[0].GetType());

            Console.WriteLine("nombres.Length      = " + nombres.Length);
            Console.WriteLine("nombres[1]          = " + nombres[1]);
            Console.WriteLine("racines.Length      = " + racines.Length);
            Console.WriteLine("racines[0]          = " + racines[0]);
            Console.WriteLine("racines[nombres[1]] = " + racines[nombres[1]]);

        }

        static void Sem10Exercice2()
        {
            string[] titres = new string[10];
            string[] telephones = new string[9];

            double[] notesLabo4 = new double[44];
            Random r = new ();
            for (int i = 0; i < notesLabo4.Length; i++)
            {
                notesLabo4[i] = r.Next(8, 16);
            }

            double[][] notesLabos = new double[5][];
            for (int i = 0; i < notesLabos.Length; i++)
            {
                notesLabos[i] = new double[44];
                for (int j = 0; j < notesLabos[i].Length; j++)
                {
                    notesLabos[i][j] = r.Next(8, 16);
                }
            }
        }

        static void Sem10Exercice3()
        {
            string[] fruits = { "Ananas", "Banane", "Cerise", "Datte", "Figue", "Grenade", "Kiwi" };
            // Imprimer le contenu d'un tableau à partir du début.
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.Write(fruits[i] + " ");
            }
            Console.WriteLine();

            // Imprimer le contenu d'un tableau à partir de la fin.
            for (int i = fruits.Length - 1; i >= 0; i--)
            {
                Console.Write(fruits[i] + " ");
            }
            Console.WriteLine();

            // Imprimer le contenu d'un tableau en sautant une case sur deux.
            for (int i = 0; i < fruits.Length; i += 2)
            {
                Console.Write(fruits[i] + " ");
            }
            Console.WriteLine();

            // Imprimer le contenu de la deuxième moitié du tableau
            for (int i = fruits.Length / 2; i < fruits.Length; i++)
            {
                Console.Write(fruits[i] + " ");
            }
            Console.WriteLine();
        }
        static void ImprimerALEnversMajuscule(string chaine)
        {
            string majuscule = chaine.ToUpper();
            for (int i = majuscule.Length - 1; i >= 0; i--)
            {
                Console.Write(majuscule[i]);
            }
            Console.WriteLine();
        }

        static bool EstPalindrome(string chaine)
        {
            for (int i = 0; i < chaine.Length; i++)
            {
                if (chaine[i] != chaine[chaine.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static void Sem10Exercice4()
        {
            Console.WriteLine("Entrer un mot");
            string mot = Console.ReadLine() ?? "";

            ImprimerALEnversMajuscule(mot);
            if (EstPalindrome(mot))
            {
                Console.WriteLine(mot + " est un palindrome");
            }
            else
            {
                Console.WriteLine(mot + " n'est pas un palindrome");
            }
        }

        static void Main(string[] _)
        {
            Sem8Exercice1();
            Sem8Exercice2();
            Sem8Exercice3();
            Console.WriteLine(Sem8Exercice6A("Je suis très malade j'ai mal au nez;"));
            Sem8Exercice6B("Ananas");

            Sem10Exercice1();
            Sem10Exercice2();
            Sem10Exercice3();
            Sem10Exercice4();
        }
    }
}