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

            //Ergebnis berechnen
            double ergebnis = Berechnung(operation, zahl1, zahl2);

            //Ausgabe des Ergebnisses
            AusgabeErgebnis(ergebnis, operation, zahl1, zahl2);
            HoleEingabe("Zum Beenden bitte Enter Drücken.");

        }

        static void AusgabeErgebnis(double ergebnis, string operation, double zahl1, double zahl2)
        {
            Console.WriteLine("Ergebnis: " + zahl1 + " " + operation + " " + zahl2 + " = " + ergebnis);
        }

        static double Berechnung (string operation, double zahl1, double zahl2)
        {
            double ergebnis = 0;
            switch (operation)
            {
                case "+":
                    ergebnis = Addiere(zahl1, zahl2);
                    
                    break;
                case "-":
                    ergebnis = Subtrahiere(zahl1, zahl2);
                    break;
                case "/":
                    ergebnis = Dividiere(zahl1, zahl2);
                    break;
                case "*":
                    ergebnis = Multipliziere(zahl1, zahl2);
                    break;
                default:
                    Console.WriteLine("Du hast eine ungültige Auswahl getroffen");
                    break;
            }
            return ergebnis;
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

        static double Multipliziere (double zahl1, double zahl2)
        {
            double ergebnis = zahl1 * zahl2;

            return ergebnis;
        }

        static double Dividiere (double zahl1, double zahl2)
        {
            double ergebnis = 0;
            if(zahl2 != 0) { 
            ergebnis = zahl1 / zahl2;
            }
            else
            {
                Console.WriteLine("Division durch 0 ist nicht erlaubt.");
            }
            return ergebnis;

        }
    }
}
