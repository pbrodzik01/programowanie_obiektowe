//PATRYCJA BRODZIK
using System;

namespace Programowanie_Obiektowe_6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Zadanie 1
            Console.WriteLine("Zadanie 1: \n");
            DzieleniePrzez0 wyjątek = new DzieleniePrzez0(0);
            Console.WriteLine("20/ " + wyjątek.getX() + " = " + wyjątek.iloraz());
            Console.WriteLine("Komunikat występujący po wyjątku, program działaj dalej\n\n");
            #endregion

            #region Zadanie 2
            Console.WriteLine("Zadanie 2:\n");
            Zakres_Tablicy wz = new Zakres_Tablicy(2, 1);
            int wynik = wz.element(4);
            Console.WriteLine("Metoda zwróciła wynik: " + wynik);
            Console.WriteLine("Program działa dalej\n\n");
            #endregion

            #region Zadanie 3
            Console.WriteLine("Zadanie 3:\n");
            WieleWyjatkow ww1 = new WieleWyjatkow(2, 1);
            int a = ww1.element(4);
            Console.WriteLine($"Wynik metody element: {a} \n");

            WieleWyjatkow ww2 = new WieleWyjatkow(2, 0);
            int a2 = ww2.element(1);
            Console.WriteLine($"Wynik metody element: {a2} \n");

            WieleWyjatkow ww3 = new WieleWyjatkow(2, 0);
            int a3 = ww3.element(4);
            Console.WriteLine($"Wynik metody element: {a3} \n");
            #endregion

            #region Zadanie 4
            Console.WriteLine("Zadanie 4:\n");
            Arytmetyka ar = new Arytmetyka(8, 7);
            Console.WriteLine($"Wynik: {ar.ff()}\n");
            #endregion

            #region Zadanie 5
            Console.WriteLine("Zadanie 5:\n");
            Tablica_N tab1 = new Tablica_N();
            try
            {
                int m = int.Parse(Console.ReadLine());
                tab1.wypełnij(m);
                tab1.wyświetl(m);
                tab1.średnia(m);
            }
            catch (FormatException ex)
            { Console.WriteLine(ex.Message); }
            catch (IndexOutOfRangeException ex)
            { Console.WriteLine(ex.Message); }
            #endregion

            #region Zadanie 6
            Console.WriteLine("Zadanie 6:\n ");

            Console.WriteLine("Podaj ścieżkę do pliku: ");
            string path = Console.ReadLine();
            OpenStream(path);
            #endregion
        }

        #region OpenStream
        static void OpenStream(string path)
        {
            try
            {
                if (path.Length < 3)
                { throw new FileTooShortException(); }
                else
                {
                    StreamReader sr = new StreamReader(path);
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    { Console.WriteLine(line); }
                    sr.Close();
                }
            }
            catch (FileTooShortException ex)
            { Console.WriteLine(ex.Message); }
            catch (FileNotFoundException ex)
            { Console.WriteLine(ex.Message); }
            catch (IOException ex)
            { Console.WriteLine(ex.Message); }
        }

        class PathIsNullExecption : IOException
        {
            public override string Message
            { get { return "Nie podano ścieżki do pliku."; } }
        }

        class FileTooShortException : IOException
        {
            public override string Message
            { get { return "Długość pliku conajmniej 3 linie!"; } }
        }
        #endregion
    }

    #region Zadanie 1 - class
    class DzieleniePrzez0
    {
        int x;
        public DzieleniePrzez0(int x_) { x = x_; }
        public int iloraz()
        {
            int wynik = -1;

            try
            { wynik = 20 / x; }
            catch (DivideByZeroException ex)
            { Console.WriteLine("Wykryto dzielenie przez zero " + ex); }
            catch (ArithmeticException ex)
            { Console.WriteLine("Wykryto błąd arytmetyczny " + ex); }
            return wynik;
        }
        public int getX() { return x; }
    }
    #endregion

    #region Zadanie 2 - class
    class Zakres_Tablicy
    {
        int[] x;
        public Zakres_Tablicy(int x_, int y_)
        {
            x = new int[x_];
            x[0] = y_;
        }
        public int element(int indx)
        {
            try
            {
                int el = x[indx];
                return el;
            }
            catch (IndexOutOfRangeException ex)
            { Console.WriteLine("Nastąpiło przekroczenie zakresu tablicy" + ex.Message); }
            return -1;
        }
    }
    #endregion

    #region Zadanie 3 - class
    class WieleWyjatkow
    {
        int[] x;
        public WieleWyjatkow(int x_, int y_)
        {
            x = new int[x_];
            x[0] = y_;
        }
        public int element(int p)
        {
            try
            {
                int el = 1 / x[0];
                x[p] = el;
                return el;
            }
            catch (ArithmeticException ex)
            { Console.WriteLine("Wykryto dzielenie przez zero " + ex.Message); }
            catch (IndexOutOfRangeException ex)
            { Console.WriteLine("Nastapiło przekroczenie zakresu tablicy " + ex.Message); }
            finally
            { Console.WriteLine("Koniec sprawdzania wyjątków"); }
            return -1;
        }
    }
    #endregion

    #region Zadanie 4 - class
    class Arytmetyka
    {
        int a;
        int b;
        double wynik = 0;

        public Arytmetyka(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public double ff()
        {
            try
            {  wynik = ((a + b) / (2 * a - b)); }
            catch (DivideByZeroException ex)
            { Console.WriteLine($"Wykryto dzielenie przez 0 {ex.Message}"); }
            catch (NullReferenceException ex)
            { Console.WriteLine($"Pusty typ danych {ex.Message}"); }
            catch (ArrayTypeMismatchException ex)
            { Console.WriteLine($"Wykryto obiekt który nie jest liczbą {ex.Message}"); }
            return wynik;
        }
    }
    #endregion

    #region Zadanie 5 - class
    class Tablica_N
    {
        Random rand = new Random();

        int zakres;
        public int getZakres() { return zakres; }
        public void setZakres(int zakres) { this.zakres = zakres; }

        int[] tab = new int[10];
        public double śrd = 0;

        public void wypełnij(int m)
        {
            for (int i = 0; i < m; i++)
            {
                tab[i] = rand.Next(10);
            }
        }
        public void wyświetl(int m)
        {
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"[{i + 1}: ]" + tab[i]);
            }
        }
        public void średnia(int m)
        {
            for (int i = 0; i < 10; i++)
            {
                śrd += tab[i];
            }
            Console.WriteLine("Średnia arytmetyczna: " + śrd / m);
        }
    }
    #endregion    
}
