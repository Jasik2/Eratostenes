using System;

class SitoEratostenesa
{
    static void Main(string[] args)
    {
        int n = 100;
        bool[] sito = WypelnijSito(n);
        WyswietlLiczbyPierwsze(sito);
    }

    /*
    nazwa funkcji: WypelnijSito
    parametry wejściowe: n - górna granica zakresu liczb
    wartość zwracana: Tablica typu bool reprezentująca sito Eratostenesa
    informacje: Wypełnia tablicę (sito), gdzie indeksy odpowiadające liczbom pierwszym są ustawione na true
    autor: <numer zdającego>
    */
    static bool[] WypelnijSito(int n)
    {
        bool[] sito = new bool[n + 1];
        for (int i = 2; i <= n; i++)
        {
            sito[i] = true;
        }

        int granica = (int)Math.Sqrt(n);
        for (int i = 2; i <= granica; i++)
        {
            if (sito[i])
            {
                for (int j = i * i; j <= n; j += i)
                {
                    sito[j] = false;
                }
            }
        }
        return sito;
    }

    /*
    nazwa funkcji: WyswietlLiczbyPierwsze
    parametry wejściowe: sito - tablica bool reprezentująca sito Eratostenesa
    wartość zwracana: brak
    informacje: Wyświetla wszystkie liczby pierwsze z zakresu sita na konsoli
    autor: <numer zdającego>
    */
    static void WyswietlLiczbyPierwsze(bool[] sito)
    {
        Console.WriteLine("Liczby pierwsze w przedziale 2..100:");
        for (int i = 2; i < sito.Length; i++)
        {
            if (sito[i])
            {
                Console.Write(i + " ");
            }
        }
    }
}
