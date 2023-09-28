using System.Runtime.CompilerServices;

namespace OutilMonnaie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre nom:");
            string name = Console.ReadLine();
            Console.WriteLine($"Bienvenue à l'application, {name}!");
            
            Console.WriteLine("Voulez-vous entrer un montant en CAD ou en USD?");
            string currency = Console.ReadLine();
            Console.WriteLine("Entrez un montant:");
            double montant_dep = Convert.ToDouble(Console.ReadLine());
            double montant_res = 0;
            if (currency == "USD" || currency == "usd")
            {
                montant_res = montant_dep * 1.35;
                Console.WriteLine($"Le montant est de: {montant_res}$ CAD");
            }
            if (currency == "CAD" || currency == "cad")
            {
                montant_res = montant_dep * 0.74;
                Console.WriteLine($"Le montant est de: {montant_res}$ USD");
            }

            Console.ReadKey();
        }
    }
}