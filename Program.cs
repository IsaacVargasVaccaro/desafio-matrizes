using System;


namespace desafio_matrizes {
    class Program {
        static void Main(string[] args) {

        
            Console.WriteLine("Digite o tamanho que deseja de sua matriz");
            string[] tamanhoDaMatriz = Console.ReadLine().Split(' ');
            int m = int.Parse(tamanhoDaMatriz[0]);
            int n = int.Parse(tamanhoDaMatriz[1]);

            int[,] numeros = new int[m,n];

            Console.WriteLine("Digite os números que deseja adicionar");
            for (int i = 0; i < m; i++) {
                string[] valor = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    numeros[i, j] = int.Parse(valor[j]);
                }
            }

            Console.WriteLine("Qual número deseja procurar para mostrar os valores à esquerda, acima, à direita?");
            int numeroASerProcurado= int.Parse(Console.ReadLine());

            for ( int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++){
                    if (numeros[i, j] == numeroASerProcurado) {
                        Console.WriteLine ("Posição do elemento digitado é" +  i + ", " + j);             
                  
            if (j > 0) {
                Console.WriteLine("Esquerda: " + numeros[i, j - 1]);
            }

            // Verifica se há um elemento acima na matriz
            if (i > 0) {
                Console.WriteLine("Acima: " + numeros[i - 1, j]);
            }

            // Verifica se há um elemento à direita na matriz
            if (j < n - 1) {
                Console.WriteLine("Direita: " + numeros[i, j + 1]);
            }

            // Verifica se há um elemento abaixo na matriz
            if (i < m - 1) {
                Console.WriteLine("Abaixo: " + numeros[i + 1, j]);
                
                     }
                  }
               }
            }      
        }
    }
}



