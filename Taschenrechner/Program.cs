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
            string zahl1AlsString = HoleEingabe("Erste zahl eingeben:");
            string operation = HoleEingabe("Bitte gib die zu verwendende Operation an (+ oder -):");
            string zahl2AlsString = HoleEingabe("Zweite Zahl eingeben:");            

            //Konvertierung in Gleitkommazahl
            //TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double zahl1 = Convert.ToDouble(zahl1AlsString);
            double zahl2 = Convert.ToDouble(zahl2AlsString);
            double ergebnis = 0;

            //Ergebnis berechnen
            if(operation == "+")
            {
                 ergebnis = Addiere(zahl1, zahl2);
            }
            else if (operation == "-")
            {
                 ergebnis = Subtrahiere(zahl1, zahl2);
            }
            else
            {
                Console.WriteLine("Du hast eine ungültige Auswahl getroffen");
            }

            //Ausgabe des Ergebnisses
            Console.WriteLine("Ergebnis: " + zahl1 + " " + operation + " " + zahl2 + " = " + ergebnis);
            HoleEingabe("Zum Beenden bitte Enter Drücken.");
        }



        static string HoleEingabe(string ausgabeText)
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
        
        static double Subtrahiere(double zahl1, double zahl2)
        {
            double ergebnis = zahl1 - zahl2;

            return ergebnis;
        }
    }
}
