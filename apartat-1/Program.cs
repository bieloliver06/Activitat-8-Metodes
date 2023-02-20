namespace Apartat_1
{
    class Program
    {
        static void Main()
        {
            string? input;
            int a;
            int b;
            while (true)
            {
                Console.WriteLine("Introdueix el primer nombre :");
                input = Console.ReadLine();
                if (int.TryParse(input, out a))
                {
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("Introdueix el primer nombre :");
                input = Console.ReadLine();
                if (int.TryParse(input, out b))
                {
                    break;
                }
            }
            Console.WriteLine("El resultat és : " + Multiplicador(a, b));
        }
        
        static int Multiplicador(int a, int b)
        {
            int resultat = 1;
            for (int i = a; i <= b; i++)
            {
                resultat = resultat * i;
            }
            return resultat;
        } 
    }
}