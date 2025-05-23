using System;

namespace CursoCSharp
{
    public class TratamentoExcecoes
    {
        public void ExecutarDivisao(int numerador, int denominador)
        {
            try
            {
                // Tentar executar este bloco de código
                int resultado = numerador / denominador;
                Console.WriteLine($"Resultado da divisão: {resultado}");
            }
            catch (DivideByZeroException ex)
            {
                // Bloco de código executado em caso de exceção de divisão por zero
                Console.WriteLine("Erro: Tentativa de divisão por zero.");
                Console.WriteLine($"Detalhes da Exceção: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Bloco de código para capturar outras exceções
                Console.WriteLine("Ocorreu um erro inesperado.");
                Console.WriteLine($"Detalhes da Exceção: {ex.Message}");
            }
            finally
            {
                // Bloco de código que sempre será executado, independentemente de uma exceção ter ocorrido ou não
                Console.WriteLine("Operação de divisão finalizada.");
            }
        }

        public void MetodoSemExcecao()
        {
            try
            {
                Console.WriteLine("Executando código sem exceção...");
            }
            catch (Exception)
            {
                // Este bloco não será executado, pois não há exceção
            }
            finally
            {
                // O bloco finally ainda será executado
                Console.WriteLine("Este bloco finally sempre é executado.");
            }
        }
    }
}
