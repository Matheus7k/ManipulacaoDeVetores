internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetorA = new int[5];
        int[] vetorB = new int[5];
        int[] vetorC = new int[10];

        populaVetor(vetorA, "vetor A");
        populaVetor(vetorB, "vetor B");

        copiaVetor(vetorA, vetorB, vetorC);

        imprimeVetor(vetorC, "vetor C");

        ordenaVetor(vetorC);
        imprimeVetor(vetorC, "vetor C ordenado");


        void populaVetor(int[] vetor, string texto)
        {
            Console.WriteLine($"Informe 5 valores para o {texto}: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"{i+1}° posição: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }

        void copiaVetor(int[] vetorA, int[] vetorB, int[] vetorC)
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

        void imprimeVetor(int[] vetor, string texto)
        {
            Console.Write($"\nImprimindo o {texto}: ");
            foreach (int i in vetor)
            {
                Console.Write(i + " ");
            }
        }

        void ordenaVetor(int[] vetor)
        {
            int aux;
            for(int i = 0; i < vetor.Length; i++)
            {
                for(int j = 0; j < vetor.Length; j++)
                {
                    if (vetor[i] < vetor[j])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[i];
                        vetor[i] = aux;
                    }
                }
            }
        }
    }
}