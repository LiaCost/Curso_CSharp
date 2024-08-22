using System;
namespace CursoCSharp
{
    //Crie uma classe Biblioteca com uma lista privada de Livro representando o acervo.
    //Adicione métodos públicos para adicionar e remover livros do acervo, 
    //garantindo que a lista só seja manipulada através desses métodos.

    class Biblioteca 
    {
        
        private List<Livro> acervo = new List<Livro>();

        public void Adicionar(Livro l)
        {
            acervo.Add(l);           
        }

        public void Remover(Livro l)
        {
           if(acervo.Contains(l))
           {
               acervo.Remove(l);
           }
        }

    }
}