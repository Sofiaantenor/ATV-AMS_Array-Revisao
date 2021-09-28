using System;

namespace ATV_ArrayRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Cantores = new string[5];

            Cantores[0] = "Ivete Sangalo";
            Cantores[1] = "Ed Sheeran";
            Cantores[2] = "Chico Buarque";
            Cantores[3] = "Shawn Mendes";
            Cantores[4] = "Marilia Mendonça";

            Console.WriteLine(" ");
            Console.WriteLine(Cantores[1]);

            Console.WriteLine(" ");
            Console.WriteLine("   EXIBIÇÃO DA LISTA LISTA DE CANTORES COM LAÇO FOREACH:");

            foreach (string cant in Cantores)
            {
                Console.WriteLine(cant);
            }

            Console.WriteLine(" ");
            Console.WriteLine("   EXIBIÇÃO DA LISTA LISTA DE CANTORES COM LAÇO FOR:");

            for (int i = 0; i < Cantores.Length; i++)
           {
                Console . WriteLine (Cantores[i]);
           }
        
            Console.WriteLine(" ");

        }
    }
}
