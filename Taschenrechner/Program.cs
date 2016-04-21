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
            string zahl1AlsString = HoleSummanden("Erste zahl eingeben:");
            string zahl2AlsString = HoleSummanden("Zweite Zahl eingeben:");

            //Konvertierung in Gleitkommazahl
            //TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double zahl1 = Convert.ToDouble(zahl1AlsString);
            double zahl2 = Convert.ToDouble(zahl2AlsString);
           
            //Ergebnis berechnen
            double ergebnis = Addiere(zahl1, zahl2);

            //Ausgabe des Ergebnisses
            Console.WriteLine("Ergebnis: " + zahl1 + " + " + zahl2 + " = " + ergebnis);
            WarteAufBenutzerEingabe();
        }

        static string HoleSummanden(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string summand = Console.ReadLine();

            return summand;
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
