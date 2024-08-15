using System;

namespace CursoCSharp
{
    public class Exercicios
    {

        /*   // Criando e Inicializando um Array
          // Crie um array de inteiros chamado numeros com capacidade para 5 elementos. 
          // Inicialize-o com os valores 2, 4, 6, 8, 10 e imprima todos os elementos.
          /*     public  void InicializandoumArray ()
              {
                  int[] numeros = {1,2,3,4,5};            

                  foreach (int i in numeros)
                  {
                      Console.WriteLine(i);
                  }
              } */

        // Acessando Elementos de um Array
        // Dado o array int[] valores = {1, 3, 5, 7, 9};, imprima o terceiro
        // elemento do array. 
        /*      public void AcessandoElementosArray()
                {
                    int[] valores = {1, 3, 5, 7, 9};
                        Console.WriteLine(valores[2]);

                } */

        // Alterando Valores em um Array
        // Crie um array de strings chamado nomes com os valores "Ana", "Bruno", "Carla". 
        // Mude o valor de "Bruno" para "Beto" e depois imprima todos os elementos do array. 
        /* public void AlterandoValoresArray()
        {
            string[] nomes = { "Ana", "Bruno", "Carla"};

            nomes[1] = "Beto";  

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        } */

        //Calculando a Soma dos Elementos de um Array
        //Crie um array de inteiros chamado notas com os valores 7, 8, 9, 10, 6. 
        //Calcule e imprima a soma de todos os elementos do array.
        /*  public void SomaArray()
            {
                int [] notas = {7, 8, 9, 10, 6};

                int soma = 0; 

                foreach (int nota in notas)
                {
                    soma += nota;
                }

                Console.WriteLine("A soma dos elementos do array é: " + soma);

            } */

        //Procurando um Elemento em um Array
        //Dado o array int[] numeros = {5, 10, 15, 20, 25};, escreva um código que verifique se o número
        //15 está presente no array e imprima uma mensagem confirmando. 
        /*  public void ProcurandoArray()
            {
                int[] numeros = {5, 10, 15, 20, 25};
                bool contemNum = numeros.Contains(15);
                Console.WriteLine("\nA lista contém o número '15'? " + contemNum);
            }
        */

        //Criando e Adicionando Elementos em uma List
        //Crie uma List<string> chamada frutas. Adicione as frutas "Maçã", "Banana", "Laranja" e imprima todos os elementos da lista.
        /*     public void CriandoAdicionandoList()
            {
                List<string> frutas  = new List<string>()
                {
                    "Maçã",
                    "Banana",
                    "Laranja"
                };

                foreach (string fruta in frutas)
                {
                    Console.WriteLine(fruta);
                }

            } */

        //Removendo um Elemento de uma List
        //Crie uma List<int> chamada numeros e adicione os valores 1, 2, 3, 4, 5.
        //Remova o número 3 da lista e depois imprima os elementos restantes.
        /*     public void RemovendoList()
            {
                List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
                numeros.Remove('3'); 
                numeros.RemoveAt(2); 
                Console.WriteLine("\nLista de números após remoções:");
                foreach ( int numero in numeros)
                {
                    Console.WriteLine(numero);
                }
            } */

        //Acessando um Elemento Específico em uma List
        //Dada a List<string> chamada cidades = new List<string> {"São Paulo", "Rio de Janeiro", "Belo Horizonte"}, 
        //imprima a segunda cidade da lista.
        /*     public void AcessandoEspecíficoList()
            {
                List<string> cidades = new List<string> {"São Paulo", "Rio de Janeiro", "Belo Horizonte"};
                Console.WriteLine("Segundo elemento da lista 'cidades': " + cidades[1]);

            } */

        //Contando Elementos em uma List
        //Crie uma List<string> chamada animais e adicione os valores "Cachorro", "Gato", "Coelho". 
        //Escreva um código que imprima quantos elementos existem na lista.
        /*     public void ContandoList()
            {
                List<string> animais = new List<string>()
                {
                    "Cachorro", 
                    "Gato",
                    "Coelho"
                };

                Console.WriteLine("Número de elementos na lista 'animais': " + animais.Count);
            } */

        // Variável Local em um Método
        //Escreva um método chamado CalculaSoma que declare uma variável local int soma 
        //e calcule a soma de dois números passados como parâmetros.
        // A variável soma deve estar acessível apenas dentro deste método.
        /* public void CalculaSoma(int num1, int num2)
        {
             int soma = num1 + num2; 
            Console.WriteLine($"A soma de {num1} e {num2} é {soma}.");
        } */

        //Variável Global em uma Classe
        //Crie uma classe chamada Carro com uma variável global string marca. 
        //No método Main, instancie um objeto Carro, 
        //defina a marca do carro como "Toyota" e imprima a marca. */
        /*      public string? marca;

             public void Imprimir()
             {
                 Console.WriteLine($"A marca do carro e: {marca}");
             } */

        // Conflito de Escopo
        //Escreva um método onde você declare uma variável local com o mesmo nome de uma variável global da classe. 
        //Mostre como acessar ambas as variáveis no mesmo método.
        /*     public string marca = "MarcaGlobal";

            public void MostrarMarca()
            {
                
                string marca = "MarcaLocal";

                Console.WriteLine("Variável local: " + marca);
                Console.WriteLine("Variável global: " + this.marca);
            } */

        //Variável Local dentro de um Bloco Condicional
        //Escreva um código onde uma variável int x seja declarada dentro de um bloco if. 
        //Tente acessar essa variável fora do bloco if e observe o que acontece.
       /*  public void Condicional()
        {
            if (true)
            {
                int x = 1;
                Console.WriteLine(x);
            }

            Console.WriteLine(x); 

            Conclusão
            // O escopo das variáveis locais em C# é restrito ao bloco em que foram declaradas. 
            //Isso significa que uma variável declarada dentro de um bloco if não pode ser acessada fora desse bloco.

        } */

        // Alterando o Valor de uma Variável Global
        //Crie uma variável global int contador em uma classe. 
        //No método Main, altere o valor de contador dentro de um loop for e 
        //depois imprima o valor final de contador.
            /*     public int contador = 0;
                    public void Alterandovalor()
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            contador += 1; 
                        }
                    } */

        //Capturando uma Exceção de Conversão de Tipo
        //Tente converter uma string não numérica para um inteiro usando int.Parse. 
        //Use try-catch para capturar a exceção e imprima uma mensagem apropriada.
           /*  public void Capturando()
            {
                string str = "abc";

                try
                {
                    
                    int numero = int.Parse(str);
                    Console.WriteLine("Número convertido com sucesso: " + numero);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Erro de conversão: A string fornecida não é um número válido.");
                    Console.WriteLine("Detalhes da exceção: " + ex.Message);
                }
            } */

        //  Lançando Exceções
        //Escreva um método que recebe um número inteiro. 
        //Se o número for negativo, lance uma ArgumentException. 
        //Capture a exceção no método Main e imprima uma mensagem apropriada.
           /*  public void Excessao(int numero)
            {
            
                if (numero < 0)
                {
                    throw new ArgumentException("O número não pode ser negativo.");
                }

                Console.WriteLine("Número aceito: " + numero);
            } */





    }
}

