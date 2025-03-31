//PATRYCJA BRODZIK
using System;

namespace Programowanie_Obiektowe
{
    class Program
    {
        static void alfabet()
        {
            Console.Write("Proszę podać literę: ");
            char x3 = char.Parse(Console.ReadLine());

            for (char i = 'a'; i <= x3; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void parzyste()
        {
            int suma = 0;
            Console.Write("Proszę podać x: ");
            int x5 = int.Parse(Console.ReadLine());

            for (int i = 0; i <= x5; i++) if (i % 2 == 0) suma += i;
            Console.WriteLine($"Suma: {suma}");
        }

        static int ARYTMETYCZNY(int a, int r, int n)
        {
            if (n == 1) return a;
            else return ARYTMETYCZNY(a, r, n - 1) + r;
        }

        static void Main(string[] args)
        {
            #region Zadanie 1
            Console.WriteLine("Zadanie 1: Napisz program z pętlą while, który wyświetli liczby w zakresie od 1 do 30 podzielne przez 3.\n");
            int x = 1;
            while (x <= 30)
            {
                if (x % 3 == 0) Console.Write($"{x} ");
                x++;
            }
            #endregion

            #region Zadanie 2
            Console.WriteLine("\n\n\nZadanie 2: Przygotuj program wyświetlający liczby parzyste w zakresie od 1 do 30.\n    Wykorzystaj pętlę for i instrukcję continue.\n");
            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 != 0) continue;
                Console.Write(i + " ");
            }
            Console.WriteLine();
            #endregion

            #region Zadanie 3
            Console.WriteLine("\n\nZadanie 3: Przygotuj funkcję alfabet, która jako argument pobiera litere x i wyświetla litery od 'a' do 'x'.\n   Użyj pętli while.\n");           
            alfabet();
            #endregion

            #region Zadanie 4
            Console.WriteLine("\n\nZadanie 4: Napisz program, który za pomocą instrukcji do – while zsumuje liczby całkowite w zakresie od 1 do x.\n");
            Console.Write("Proszę podać x: ");
            int x4 = int.Parse(Console.ReadLine());
            int temp = 1, suma = 0;
            do
            {
                suma += temp;
                temp++;
            } while (temp <= x4);
            Console.WriteLine($"Suma: {suma}");
            #endregion

            #region Zadanie 5
            Console.WriteLine("\n\nZadanie 5: Przygotuj funkcje parzyste, która za pomocą instrukcji for zsumuje liczby parzyste w zakresie od 0 do x.\n    Należy skorzystać z operatora modulo %.\n");
            parzyste();
            #endregion

            #region Zadanie 6
            Console.WriteLine("\n\nZadanie 6: Przygotuj program, wyświetlający w liczby z zakresu -100 do 100 w porządku malejącym.\n   Liczby powinny być podzielne przez 2, ale niepodzielne przez 3 i 8.\n   Zadanie wykonaj przy wykorzystaniu instrukcji continue.\n");
            for (int i = 100; i >= -100; i-=2)
            {          
                if (i % 3 == 0) continue;
                if (i % 8 == 0) continue;
                Console.Write(i + " ");
            }
            #endregion

            #region Zadanie 7
            Console.WriteLine("\n\n\nZadanie 7: Podczas zawodów skoków narciarskich zawodnik otrzymuje oceny za styl od 5 sędziów.\n    Ostateczna ocena za styl jest równa sumie tych trzech,\n    które pozostaną po odrzuceniu skrajnych not (czyli najmniejszej i największej).\n    Napisz program, który wczyta 5 liczb z zakresu od 0 do 20 do tablicy,\n    a następnie wyliczy oceny za styl zgodnie z podanymi wyżej zasadami.\n");
            Random rand = new Random();

            int[] oceny = new int[5];
            int suma7 = 0;

            for(int i = 0; i < oceny.Length; i++) oceny[i] = rand.Next(21);

            Console.Write("Noty: ");
            for (int i = 0; i < oceny.Length; i++) Console.Write(oceny[i] +" ");
            Console.WriteLine();

            for (int i = 0; i < oceny.Length; i++)
            {
                for (int j = 0; j < oceny.Length - 1; j++)
                {
                    if (oceny[j] > oceny[j + 1])
                    {
                        temp = oceny[j + 1];
                        oceny[j + 1] = oceny[j];
                        oceny[j] = temp;
                    }
                }
            }

            for (int i = 1; i < oceny.Length - 1; i++) suma7 += oceny[i];
            Console.WriteLine($"Ocena za styl: {suma7}");
            #endregion

            #region Zadanie 8
            Console.WriteLine("\n\nZadanie 8: Proszę napisać algorytm, który wypełni tzw.,jodełką' tablicę kwadratową oraz wyświetli n wierszy i kolumn.\n    Przykład: dla n równego 5, tablica ta jest postaci:\n    1 1 1 1 1\n    1 2 2 2 2\n    1 2 3 3 3\n    1 2 3 4 4\n    1 2 3 4 5\n");
            Console.Write("Proszę podać n: ");
            int n8 = int.Parse(Console.ReadLine());
            int[,] tab8 = new int[n8, n8];

            for (int i = 0; i < n8; i++)
            {
                for (int j = 0; j < n8; j++)
                {
                    tab8[i, j] = j + 1;

                    if (i < j || i == j)
                    {
                        tab8[i, j] = i + 1;
                    }
                    else if (i > j)
                    {
                        tab8[i, j] = j + 1;
                    }
                }
            }
            for (int i = 0; i < n8; i++)
            {
                for (int j = 0; j < n8; j++) Console.Write(tab8[i, j] + " ");
                Console.WriteLine();
            }
            #endregion

            #region Zadanie 9
            Console.WriteLine("\n\nZadanie 9: Napisz metodę rekurencyjną obliczajacą n-ty wyraz ciagu arytmetycznego.\n");
            Console.Write("Prosze podać pierwszy wyraz ciągu: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Prosze podać różnice ciągu: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Prosze podać który wyraz ciągu mam wpisać: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n{n} wyraz ciągu arytmetcznego wynosi : " + ARYTMETYCZNY(a, r, n));

            #endregion
        }
    }
}