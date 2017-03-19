using System;

namespace Passwortgenerator
{
    class Kleinbuchstaben
    {
        char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        char[] c = new char[50];    //hängt ab von der maximalen Passwortlänge
        Random index = new Random();

        public char[] ausgabe(int laenge)
        {
            for (int i = 0; i<laenge; i++)
            {
                int zufall = index.Next(0, 26); //erzeugt eine Zufallszahl zwischen 0 und 25
                c[i] = alpha[zufall];               
            }
            return c;
        }
    }
}
