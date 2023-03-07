internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetorA = new int[5];
        int[] vetorB = new int[5];
        int[] vetorC = new int[10];

        vetorA = populaVetor();
        vetorB = populaVetor();

        populaVetorC(vetorA, vetorB);

        foreach (int i in vetorC)
        {
            Console.Write(i + " ");
        }

        int[] populaVetor()
        {
            int[] vetor = new int[5];
            Console.WriteLine("Informe 5 valores para o vetor: ");
            for (int i = 0; i < 5; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }

            return vetor;
        }

        int[] populaVetorC(int[] vetorA, int[] vetorB)
        {
            int i;
            for(i = 0; i < 5; i++)
            {
                vetorC[i] = vetorA[i];
            }
            for(int j = 0; j < 5; j++)
            {
                vetorC[i] = vetorB[j];
                i++;
            }

            return vetorC;
        }
    }
}