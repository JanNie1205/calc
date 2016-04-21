using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{

    class Program
    {

        static void Main(string[] args)
        {

            // User Story "Addieren": Als Nutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
            

            // Eingabe der zahlen in Console anschließendes speichern als Variablen
            Console.Write("Erste Zahl eingeben:");
            string zahl1AlsString = Console.ReadLine();
            Console.Write("zweite Zahl eingeben:");
            string zahl2AlsString = Console.ReadLine();

            //Konvertierung in Gleitkommazahl
            double zahl1 = Convert.ToDouble(zahl1AlsString);
            double zahl2 = Convert.ToDouble(zahl2AlsString);
           
            //Ergebnis berechnen
            double ergebnis = Addiere(zahl1, zahl2);

            //Ausgabe des Ergebnisses
            Console.WriteLine("Ergebnis: " + zahl1 + " + " + zahl2 + " = " + ergebnis);
            WarteAufBenutzerEingabe();
        }

        static double Addiere(double zahl1, double zahl2)
        {
            double ergebnis = zahl1 + zahl2;

            return ergebnis;
        }

        static void WarteAufBenutzerEingabe()
        {
            Console.WriteLine("Zum Beenden bitte Enter Drücken.");
            Console.ReadLine();
        }

    }
}
