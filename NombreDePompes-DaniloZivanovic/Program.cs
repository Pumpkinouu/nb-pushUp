//ETML
//Auteur      : Danilo Zivanovic
//Date        : 18.11.2022
//Descritpion : 
namespace NombreDePompes_DaniloZivanovic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Nombre de pompes");

            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║              Nombre de pompes              ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");

            int pompes = 0;
            //Demander un nombre de pompe a effectuer 
            Console.Write("Donner un nombre de pompes :");

            //Recuperer le nombre de l'utilisateur
            string pompesSaisie = Console.ReadLine();
            //Je convertis la variable en entier
            pompes = Convert.ToInt32(pompesSaisie);


            int i = 1;
            while (i <=pompes)
            {
                Console.WriteLine(i);
                i++;
            }
            

            Console.ReadLine();
        }
    }
}