using System;

namespace Passwortgenerator
{
    class Grossbuchstaben
    {
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] c = new char[50];
        Random index = new Random();

        public char[] ausgabe(int laenge)
        {
            for (int i = 0; i < laenge; i++)
            {
                int zufall = index.Next(0, 26); //erzeugt eine Zufallszahl zwischen 0 und 25
                c[i] = alpha[zufall];
            }
            return c;
        }
    }
}
