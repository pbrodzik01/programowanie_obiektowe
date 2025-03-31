//Patrycja Brodzik
using System;
using System.Collections;
using System.Collections.Generic;

namespace Programowanie_Obiektowe_7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Zadanie 1
            //Zadanie 1
            Console.WriteLine("Zadanie 1: ");

            #region Listy
            Console.WriteLine("Listy: ");

            var rybyTluste = new List<string>();

            rybyTluste.Add("łosoś");
            rybyTluste.Add("tuńczyk");
            rybyTluste.Add("śledź");
            rybyTluste.Add("węgorz");
            rybyTluste.Add("szprot");
            rybyTluste.Add("sardynka");

            Console.WriteLine("\nLista ryb tłustych: ");
            foreach (var item in rybyTluste)
            {
                Console.Write(item + " ");
            }

            var rybyChude = new List<string>()
            {
                "pstrąg",
                "sola",
                "lin",
                "tilapia",
                "morszczuk",
                "sandacz",
                "mintaj",
                "karp",
                "panga"
            };

            Console.WriteLine("\n\nLista ryb chudych: ");
            for (var i = 0; i < rybyChude.Count; i++)
            {
                Console.Write(rybyChude[i] + " ");
            }

            rybyChude.RemoveAt(0);
            rybyChude.Remove("karp");
            rybyChude.Sort();

            Console.WriteLine("\n\nList po sortowaniu i usunięciu dwóch zbyt tłustych ryb:");

            foreach (var item in rybyChude)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");

            var liczby = new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            for (var i = liczby.Count - 1; i >= 0; i--)
            {
                if (liczby[i] % 2 == 1)
                {
                    liczby.RemoveAt(i);
                }
            }

            liczby.ForEach(number => Console.WriteLine(number + " "));
            #endregion

            #region LinkedList    
            Console.WriteLine("\n\nLinkedList: \n");

            LinkedList<String> mojaLista = new LinkedList<String>();

            mojaLista.AddLast("Zofia");
            mojaLista.AddLast("Roman");
            mojaLista.AddLast("Jadwiga");
            mojaLista.AddLast("Tomasz");
            mojaLista.AddLast("Herbert");
            mojaLista.AddLast("Natasza");
            mojaLista.AddLast("Julia");

            Console.WriteLine("Początkowa zawartość listy: ");
            foreach (var item in mojaLista)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            mojaLista.RemoveFirst();
            mojaLista.Remove("Tomasz");
            mojaLista.Remove(mojaLista.Last);
            mojaLista.AddFirst("Adam");
            mojaLista.AddLast("Zbigniew");
            mojaLista.AddAfter(mojaLista.First, "Drugi");
            mojaLista.AddAfter(mojaLista.Find("Drugi"), "Trzeci");

            Console.WriteLine("\nLista po usuwaniu i dodawaniu elementów: ");
            foreach (var item in mojaLista)
            {
                Console.Write(item + " ");
            }
            #endregion

            #region Kolejka
            Console.WriteLine("\n\n\nKolejka: \n");

            Queue<string> mojaKolejka = new Queue<string>();

            mojaKolejka.Enqueue("Klient1");
            mojaKolejka.Enqueue("Klient2");
            mojaKolejka.Enqueue("Klient3");
            mojaKolejka.Enqueue("Klient4");
            mojaKolejka.Enqueue("Klient5");

            Console.WriteLine("Sprawdzenie zawartości elementu na początku kolejki: {0}", mojaKolejka.Peek());
            mojaKolejka.Dequeue();
            Console.WriteLine("Całkowita liczba elementów w kolejce po wyjsciu Klienta1: {0}", mojaKolejka.Count);

            Console.WriteLine("\nZawartość kolejki: ");
            foreach (var item in mojaKolejka)
            {
                Console.WriteLine(item + " ");
            }

            if (mojaKolejka.Contains("Klient3") == true)
            {
                Console.WriteLine("\nKlient3 jest w kolejce!");
            }
            else
            {
                Console.WriteLine("Nie ma Klienta3 w kolejce!");
            }
            mojaKolejka.Clear();

            Console.WriteLine("Całkowita liczba elementów po wykonaniu Clear(): {0}", mojaKolejka.Count);
            #endregion

            #region Stos
            Console.WriteLine("\n\nStos: \n");

            Stack<string> mojStos = new Stack<string>();

            mojStos.Push("największa");
            mojStos.Push("i");
            mojStos.Push("większa");
            mojStos.Push("wielka");
            mojStos.Push("mała");

            Console.WriteLine("Podglądamy element na szczycie stosu: {0}", mojStos.Peek());

            mojStos.Pop();

            Console.WriteLine("\nZawartość stosu: ");
            foreach (string str in mojStos)
            {
                Console.Write(str + " ");
            }
            Stack<string> mojStos2 = new Stack<string>(mojStos.ToArray());
            #endregion

            #region Zbiory
            Console.WriteLine("\n\n\nZbiory: ");

            HashSet<int> liczbyParzyste = new HashSet<int>();
            HashSet<int> liczbyNieparzyste = new HashSet<int>();

            for (int i = 0; i < 10; i++)
            {
                liczbyParzyste.Add(i * 2);
                liczbyNieparzyste.Add((i * 2) + 1);
            }

            Console.Write("\nHashSet liczbyParzyste zawiera {0} elementów: ", liczbyParzyste.Count);
            Console.Write("{");
            foreach (var item in liczbyParzyste)
            {
                Console.Write(" {0}", item);
            }
            Console.Write("}\n");

            Console.Write("\nHashSet liczbyParzyste zawiera {0} elementów: ", liczbyNieparzyste.Count);
            Console.Write("{");
            foreach (var item in liczbyNieparzyste)
            {
                Console.Write(" {0}", item);
            }
            Console.Write("}\n\n");

            HashSet<int> Liczby = new HashSet<int>(liczbyParzyste);

            Console.WriteLine("łączenie zbiorów HashSet...");
            Liczby.UnionWith(liczbyNieparzyste);
            Liczby.Add(4);

            Console.Write("Kolekcja hashSet liczby zawiera {0} elementów: ", liczby.Count);
            Console.Write("{");
            foreach (var item in Liczby)
            {
                Console.Write(" {0}", item);
            }
            Console.Write("}");

            liczbyParzyste.Remove(18);
            liczbyNieparzyste.Clear();
            #endregion

            #region Mapy
            Console.WriteLine("\n\n\nMapy: ");

            Dictionary<string, string> mojSlownik = new Dictionary<string, string>();

            mojSlownik.Add("poniedzialek", "Monday");
            mojSlownik.Add("wtorek", "Tuesday");
            mojSlownik.Add("środa", "Wednesday");
            mojSlownik.Add("czwartek", "Thursday");
            mojSlownik.Add("piątek", "Friday");
            mojSlownik.Add("sobota", "Saturday");
            mojSlownik.Add("niedziela", "Sunday");

            Console.WriteLine();

            foreach (KeyValuePair<string, string> item in mojSlownik)
            {
                Console.WriteLine("Klucz = {0}, wartość = {1}", item.Key, item.Value);
            }
            Console.WriteLine("\n\n****************************************************************************************************");
            #endregion
            #endregion

            #region Zadanie 2
            //Zadanie 2
            Console.WriteLine("Zadanie 2: \n");

            Console.Write("Podaj ilość imion: ");
            int ilość_imion = int.Parse(Console.ReadLine());
            Console.WriteLine();

            var Imiona = new List<string>();

            for (int i = 0; i < ilość_imion; i++)
            {
                Console.Write($"Proszę podać element {i + 1}: ");
                Imiona.Add(Console.ReadLine());
            }
            Imiona.Sort();

            Console.Write("\nKtóry element wyświetlić: ");
            int który_element = int.Parse(Console.ReadLine());

            Console.WriteLine($"Element {który_element}: " + Imiona[który_element - 1]);
            Console.WriteLine("\n\n****************************************************************************************************");
            #endregion

            #region Zadanie 3
            //Zadanie 3
            Console.WriteLine("Zadanie 3: \n");

            Stack<int> Elementy = new Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Element {i + 1}: ");
                Elementy.Push(int.Parse(Console.ReadLine()));
            }
            Console.Write("Ile elementów usunąć ?: ");
            int ile_usunąć = int.Parse(Console.ReadLine());

            for (int i = 0; i < ile_usunąć; i++)
            {
                Elementy.Pop();
            }

            Console.Write("Stos po usunięciu elementów: ");

            foreach (var item in Elementy)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\n\n****************************************************************************************************");
            #endregion

            #region Zadanie 4
            //Zadanie 4
            Console.WriteLine("Zadanie 4: \n");

            Console.Write("Podaj ilość liczb rzeczywistych: ");
            int liczba_lr = int.Parse(Console.ReadLine());

            HashSet<int> LiczbyRzeczywiste = new HashSet<int>();

            for (int i = 0; i < liczba_lr; i++)
            {
                Console.Write($"Element: {i + 1}: ");
                LiczbyRzeczywiste.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("\nZawartość setu: ");

            foreach (var item in LiczbyRzeczywiste)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n\n\n****************************************************************************************************");
            #endregion

            #region Zadanie 5
            //Zadanie 5
            Console.WriteLine("Zadanie 5: \n");

            Dictionary<string, int> Kalendarz = new Dictionary<string, int>();

            Kalendarz.Add("Styczeń", 31);
            Kalendarz.Add("Luty", 28);
            Kalendarz.Add("Marzec", 31);
            Kalendarz.Add("Kwiecień", 30);
            Kalendarz.Add("Maj", 31);
            Kalendarz.Add("Czerwiec", 30);
            Kalendarz.Add("Lipiec", 31);
            Kalendarz.Add("Sierpień", 31);
            Kalendarz.Add("Wrzesień", 30);
            Kalendarz.Add("Październik", 31);
            Kalendarz.Add("Listopad", 30);
            Kalendarz.Add("Grudzień", 31);

            Console.Write("Podaj nazwę miesiąca: ");
            string miesiąc = Console.ReadLine();

            Console.Write($"{miesiąc} ma {Kalendarz[miesiąc]} dni.");


            Console.WriteLine("\n\n\n****************************************************************************************************");
            #endregion

            #region Zadanie 6
            //Zadanie 6
            Console.WriteLine("Zadanie 6: \n");

            Console.WriteLine("\n\n\n****************************************************************************************************");
            #endregion

        }
    }
}

