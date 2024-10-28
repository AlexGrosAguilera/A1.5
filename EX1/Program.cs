namespace EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MARCA_FI = 0;
            int dada;
            int nMissatges;
            nMissatges = 0;
            dada = Convert.ToInt32(Console.ReadLine());
            while (dada != MARCA_FI)
            {
                nMissatges = nMissatges + 1;
                Console.WriteLine($"Iteració {nMissatges} --> {dada}");
                dada = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Total missatges : {nMissatges}");
        }
    }
}
