using System;

namespace PretCuTva
{
    class Program
    {
        static void Main(string[] args)
        {
            int pret_fara_tva, tva_procent;
            float tva_valoare, pret_cu_tva;

            Console.Write("pret = ");
            pret_fara_tva = Int16.Parse(Console.ReadLine()); //Conversie folosind Int16.Parse()

            Console.Write("procentul TVA = ");
            tva_procent = Convert.ToInt16(Console.ReadLine()); //Conversie folosind Convert.ToInt16()
            tva_valoare = pret_fara_tva * (float)tva_procent / 100; //Operatorul de conversie explicita (float) determina ca rezultatul impartirii sa fie numar real
            pret_cu_tva = pret_fara_tva + tva_valoare;

            Console.WriteLine("\nAfisarea prin concatenarea sirului de caractere cu valoarea variabilei");
          
            Console.WriteLine("pret = " + pret_fara_tva + ", procentul TVA = " + tva_procent + ", \nvaloarea TVA = " + tva_valoare + ", pretul cu TVA = " + pret_cu_tva);
            
            Console.WriteLine("\nAfisarea folosind parametri");

            Console.WriteLine("pret = {0}, procentul TVA = {1}, \n valoarea TVA = {2}, pretul cu TVA = {3}", pret_fara_tva, tva_procent, tva_valoare, pret_cu_tva);

            Console.WriteLine("\nAfisarea cu format de tiparire");
            // Afisarea folosind parametri si format de scriere
            // {0,5} se afiseaza pe 5 pozitii cu aliniere la dreapta
            // {1,-5} se afiseaza pe 5 pozitii cu aliniere la stanga
            // {2,-10:f4} se afiseaza pe 10 pozitii cu aliniere la stanga din care 5 la partea intreaga + 1 virgula + 4 zecimale
            // {3,10:c} se afiseaza pe 10 pozitii (total) cu aliniere la dreapta si moneda implicita (:c - currency)
            Console.WriteLine("pret = {0,5}, procentul TVA = {1,-5}, \n valoarea TVA = {2,-10:f4}, pretul cu TVA = {3,10:c}", pret_fara_tva, tva_procent, tva_valoare, pret_cu_tva);
            Console.ReadKey(); // Asteapta apasarea unei taste, pentru a avea timp sa vizualizam rezultatul afisat
            // Fara: Console.ReadKey(); fereastra consolei se va inchide imediat ce se termina executia aplicatiei.
        }
    }
}
