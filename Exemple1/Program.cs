namespace Exemple1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MARCA_FI = "adeu";
            string dada;
            int nMissatges;
            nMissatges = 0;
            dada = Console.ReadLine();
            while (dada != MARCA_FI) 
            {
                nMissatges = nMissatges + 1;
                Console.WriteLine($"Iteració {nMissatges} --> {dada}");
                dada = Console.ReadLine();
            }

            Console.WriteLine($"Total missatges : {nMissatges}");
        }
    }
}
