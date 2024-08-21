using CursoCSharp;
//ArrayExemplos.DemonstrarArray();
//ListExemplo.DemonstrarLista();
/* Aluno arthur = new Aluno();
arthur.nome =  "Arthur Braga Neto";
arthur.matricula = "23456";
arthur.curso = "Técnico";
Aluno suelen = new Aluno();
suelen.nome =  "Suelen Sousa Silva";
suelen.matricula = "67890";
suelen.curso = "Técnico";
Console.WriteLine($"O nome do aluno é:{suelen.nome}, o curso do aluno é: {suelen.curso}, a matrículo do aluno é {suelen.matricula}");
Console.WriteLine($"O nome do aluno é:{arthur.nome}, o curso do aluno é: {arthur.curso}, a matrículo do aluno é {arthur.matricula}"); */
/* EscopoVariaveis escopo = new EscopoVariaveis();
escopo.Metodo1();
escopo.Metodo2();
escopo.Metodo3();
escopo.ExibirContadorGlobal();
 */
 /* TratamentoExcecoes tr = new TratamentoExcecoes();
 tr.ExecutarDivisao(9, 3);
 TratamentoExcecoes tr1 = new TratamentoExcecoes();
 tr1.ExecutarDivisao(10, 0); */

/* Exercicios ex  = new Exercicios();
ex.InicializandoumArray(); */
//Exercicios exercicios = new Exercicios();
//exercicios.AcessandoElementosArray(); 
/* Exercicios exercicios = new Exercicios();
exercicios.AlterandoValoresArray(); */
/*  Exercicios exercicios = new Exercicios();
exercicios.SomaArray(); */
/* Exercicios exercicios = new Exercicios();
exercicios.ProcurandoArray();  */
/* Exercicios exercicios = new Exercicios();
exercicios.CriandoAdicionandoList();  */
/* Exercicios exercicios = new Exercicios();
exercicios.RemovendoList();   */
/* Exercicios exercicios = new Exercicios();
exercicios.AcessandoEspecíficoList();  */  
/* Exercicios exercicios = new Exercicios();
exercicios.ContandoList();   */
/* Exercicios exercicios = new Exercicios();
exercicios.CalculaSoma(5, 7);  */
/* Exercicios exercicios = new Exercicios();
exercicios.marca = "Toyota";
exercicios.Imprimir(); */
/* Exercicios exercicio = new Exercicios();
exercicio.MostrarMarca(); */
/* Exercicios exercicio = new Exercicios();
exercicio.Alterandovalor(); 
Console.WriteLine("Valor final de contador: " + exercicio.contador); */
/* Exercicios exercicio = new Exercicios();
exercicio.Capturando();  */
/* Exercicios program = new Exercicios();
    try
    {
        program.Excessao(-5);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("Erro: " + ex.Message);
    }
 */
 /* Paradigmasoo conceitos = new Paradigmasoo();

    // Explicar Orientação a Objetos
    conceitos.ExplicarOrientacaoAObjetos();

    // Explicar a diferença entre Programação Estruturada e Orientada a Objetos
    conceitos.DiferencaEntreParadigmas();

    // Explicar os Pilares da Orientação a Objetos
    conceitos.ExplicarPilares();
 */
/*  // 1. Criando Objetos (Instanciando a classe Pessoa)
            Pessoa pessoa1 = new Pessoa("Alice", 30);
            Pessoa pessoa2 = new Pessoa("Bob", 25);

            // 2. Usando Métodos de Instância (Métodos não estáticos)
            pessoa1.ExibirInformacoes();
            pessoa2.ExibirInformacoes();

            // 3. Usando Método Estático (Pertence à Classe, não à instância)
            Pessoa.ExibirNumeroDePessoas();

            // 4. Membros de Instância vs. Membros Estáticos
            Console.WriteLine($"Pessoa1: {pessoa1.Nome}, Idade: {pessoa1.Idade}");
            Console.WriteLine($"Pessoa2: {pessoa2.Nome}, Idade: {pessoa2.Idade}");
            Console.WriteLine($"Número total de pessoas: {Pessoa.NumeroDePessoas}");
 */
  // Instanciando a classe Produto usando o construtor padrão
            Produto produto1 = new Produto();
            produto1.ExibirInformacoes();

            // Instanciando a classe Produto usando o construtor com parâmetros
            Produto produto2 = new Produto("Smartphone", 1999.99m, 50);
            produto2.ExibirInformacoes();

            // Modificando atributos usando propriedades
            produto1.Nome = "Notebook";
            produto1.Preco = 2999.99m;
            produto1.Estoque = 25;
            produto1.ExibirInformacoes();

            // Acessando método protegido através da classe derivada
            ProdutoEspecial produtoEspecial = new ProdutoEspecial();
            produtoEspecial.ExibirMetodoProtegido();







 