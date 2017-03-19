using System;

namespace Passwortgenerator
{
    class Sonderzeichen
    {
        char[] alpha = "!§$%&/()=?{[]}*-+,.-_;".ToCharArray();
        char[] c = new char[50];    //hängt ab von der maximalen Passwortlänge
        Random index = new Random();

        public char[] ausgabe(int laenge)
        {
            for (int i = 0; i < laenge; i++)
            {
                int zufall = index.Next(0, 22); //erzeugt eine Zufallszahl zwischen 0 und 21
                c[i] = alpha[zufall];
            }
            return c;
        }
    }
}
