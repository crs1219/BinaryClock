using System;

class BinaryClock
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scrieti un program de consola care primeste ca input ora curenta sub forma 10:37:49 si afiseaza ceasul binar corespunzator.");
        Console.WriteLine("Ceasul binar este un ceas care afiseaza ora in baza 2. Ceasul binar are 6 leduri pentru fiecare cifra a orei, 6 leduri pentru fiecare cifra a minutelor si 6 leduri pentru fiecare cifra a secundelor. Ledurile sunt aprinse daca cifra este 1 si stinse daca cifra este 0. De exemplu, pentru ora 10:37:49, ceasul binar arata astfel: 000001 011011 011001. Ceasul binar este folosit pentru a invata copiii sa citeasca ceasul analogic. Ceasul analogic este un ceas cu 3 ace care arata ora, minutele si secundele. Ceasul analogic este folosit pentru a arata ora curenta.");

        // preluam ora curenta
        Console.WriteLine("Introduceti ora curenta sub forma 10:37:49");
        string oraCurenta = Console.ReadLine();

        string[] oraCurentaSplit = oraCurenta.Split(':');   // splituim ora curenta dupa :

        // convertim string-urile in int-uri
        int ora = int.Parse(oraCurentaSplit[0]);
        int minute = int.Parse(oraCurentaSplit[1]);
        int secunde = int.Parse(oraCurentaSplit[2]);

        string oraBinar = Convert.ToString(ora, 2).PadLeft(6, '0');   // convertim ora in baza 2 si adaugam 0-uri la stanga pana cand lungimea string-ului este 6

        Console.WriteLine("Ora binara este: " + oraBinar);

        string minuteBinar = Convert.ToString(minute, 2).PadLeft(6, '0');   // convertim minutele in baza 2 si adaugam 0-uri la stanga pana cand lungimea string-ului este 6

        Console.WriteLine("Minutele binare sunt: " + minuteBinar);

        string secundeBinar = Convert.ToString(secunde, 2).PadLeft(6, '0');   // convertim secundele in baza 2 si adaugam 0-uri la stanga pana cand lungimea string-ului este 6

        Console.WriteLine("Secundele binare sunt: " + secundeBinar);

        Console.WriteLine("Ceasul binar este: " + oraBinar + " " + minuteBinar + " " + secundeBinar);

        Console.ReadKey();
    }
}

