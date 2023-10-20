namespace ExercicesTableau
{
    internal class Program
    {
        static void Exercice1()
        {
            Console.WriteLine("Exercice 1");
            int[] lancers = { 5, 2, 1, 6, 5, 1, 3, 6, 3, 4 };
            Console.WriteLine(lancers[0]);
            Console.WriteLine(lancers[7]);
            //Console.WriteLine(lancers[87]);
            //Console.WriteLine(lancers[-1]);
        }

        static void Exercice2()
        {
            Console.WriteLine("Exercice 2");
            int[] fratries = { 5, 2, 1, 3, 3, 2, 1, 1, 1, 6, 4, 4 };
            fratries[7]++;
            for (int i = 0; i < fratries.Length; i++)
            {
                Console.Write(i + ":" + fratries[i] + " ");
            }

            int enfantsUniques = 0;
            for (int i = 0; i < fratries.Length; i++)
            {
                if (fratries[i] == 1)
                {
                    enfantsUniques++;
                }
            }
            Console.WriteLine($"Il y a {enfantsUniques} enfants uniques");
        }

        static void Exercice3()
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
            {
                Console.Write(noms[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Exercice 3.b");
            Console.WriteLine("Combien d'étudiants avez-vous?");
            int.TryParse(Console.ReadLine(), out int n);
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
            Console.WriteLine("Contient Bob? " + Exercice5A(nomsB));
            Console.WriteLine("Indice Eric? " + Exercice5B(nomsB));
            Console.WriteLine("Nombres de Philippe? " + Exercice5C(nomsB));
           
            Exercice5D(nomsB);
            for (int i = 0; i < nomsB.Length; i++)
            {
                Console.Write(nomsB[i] + " ");
            }

        }

        static bool Exercice5A(string[] noms)
        {
            for (int i = 0; i < noms.Length; i++)
            {
                if (noms[i] == "Bob")
                {
                    return true;
                }
            }
            return false;
        }


        static int Exercice5B(string[] noms)
        {
            for (int i = 0; i < noms.Length; i++)
            {
                if (noms[i] == "Eric")
                {
                    return i;
                }
            }
            return -1;
        }


        static int Exercice5C(string[] noms)
        {
            int nbPhilippes = 0;
            for (int i = 0; i < noms.Length; i++)
            {
                if (noms[i] == "Philippe")
                {
                    nbPhilippes++;
                }
            }
            return nbPhilippes;
        }


        static void Exercice5D(string[] noms)
        {
            for (int i = 0; i < noms.Length; i++)
            {
                if (noms[i] == "Bob")
                {
                    noms[i] = "Robert";
                }
            }
        }

        static string Exercice6A(string texte)
        {
            return texte.Replace('m', 'b').Replace('M', 'B').Replace('n', 'd').Replace('N', 'D');
        }

        static void Exercice6B(string texte)
        {
            texte = texte.ToUpper();
            for(int i = texte.Length - 1; i >= 0; i--)
            {
                Console.Write(texte[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] _)
        {
            Exercice1();
            Exercice2();
            Exercice3();
            Console.WriteLine(Exercice6A("Je suis très malade j'ai mal au nez;"));
            Exercice6B("Ananas");
        }
    }
}