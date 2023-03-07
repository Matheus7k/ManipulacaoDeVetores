internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetorA = new int[5];
        int[] vetorB = new int[5];
        int[] vetorC = new int[10];

        populaVetor(vetorA);
        populaVetor(vetorB);

        populaVetorC(vetorA, vetorB, vetorC);

        imprimeVetor(vetorC);

        void populaVetor(int[] vetor)
        {
            Console.WriteLine("Informe 5 valores para o vetor: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"{i+1}° posição: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }

        void populaVetorC(int[] vetorA, int[] vetorB, int[] vetorC)
        {
            int i;
            for(i = 0; i < vetorA.Length; i++)
            {
                vetorC[i] = vetorA[i];
            }
            for(int j = 0; j < vetorB.Length; j++)
            {
                vetorC[i] = vetorB[j];
                i++;
            }
        }

        void imprimeVetor(int[] vetor)
        {
            Console.Write($"Imprimindo o vetor C: ");
            foreach (int i in vetor)
            {
                Console.Write(i + " ");
            }
        }
    }
}