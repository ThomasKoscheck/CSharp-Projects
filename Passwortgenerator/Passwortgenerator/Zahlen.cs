using System;

namespace Passwortgenerator
{
    class Zahlen
    {
        char[] alpha = "1234567890".ToCharArray();
        char[] c = new char[50];  //hängt ab von der maximalen Passwortlänge
        Random index = new Random();

        public char[] ausgabe(int laenge)
        {
            for (int i = 0; i < laenge; i++)
            {
                int zufall = index.Next(0, 10); //erzeugt eine Zufallszahl zwischen 0 und 9
                c[i] = alpha[zufall];
            }
            return c;
        }
    }
}
