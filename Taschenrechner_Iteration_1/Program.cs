using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Iteration_1
{

    class Program
    {

        static void Main(string[] args)
        {

            // User Story "Addieren": Als Nutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen.
            int zahl1;
            int zahl2;
            int ergebnis;
            
                // Eingabe der zahlen in Console und Umwandlung in Datentyp int, anschließendes speichern als Variablen
                Console.WriteLine("Erste Zahl eingeben:");
                zahl1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("zweite Zahl eingeben:");
                zahl2 = Convert.ToInt32(Console.ReadLine());
                
                
                ergebnis = zahl1 + zahl2;
                Console.WriteLine("Ergebnis: " + zahl1 + " + " + zahl2 + " = " + ergebnis);
            Console.ReadLine();
               
            
        }
    }
}
