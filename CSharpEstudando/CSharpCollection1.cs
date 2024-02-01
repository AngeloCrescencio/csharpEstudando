using CSharpEstudando;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;

partial class Program {

    #region fila_queue_variaveis
    // fila/queue
    //static Queue<string> pedagio = new Queue<string>();
    #endregion

    static void CSharpCollection1()
    {
        //Console.WriteLine("CSharpCollection1");

        #region listas_list
        // listas

        /*
        Propriedade/Método  Descrição
        .Add	            inclui um elemento.
        .Count()	        retorna o números de elementos.
        .First()	        retorna o primeiro elemento, opcionalmente pode aceitar uma expressao lambda como condicional que vai filtrar os elementos e retornar o primeiro.
        .FirstOrDefault()	retorna o primeiro elemento ou o default se nao encontrar, opcionalmente pode aceitar uma expressao lambda como condicional que vai filtrar os elementos e retornar o primeiro.
        .ForEach()          itera pelos itens, aceita uma action (metodo anonimo) que executa algo dentro dele para cada elemento da lista.
        .GetRange()         obtem uma faixa de elementos.
        .Last()	            retorna o ultimo elementos, opcionalmente pode aceitar uma expressao lambda como condicional que vai filtrar os elementos e retornar o ultimo..
        .LastOrDefault()    retorna o ultimo elementos, ou o default se não encontrar, opcionalmente pode aceitar uma expressao lambda como condicional que vai filtrar os elementos e retornar o ultimo..
        .Reverse()	        inverte a ordem de elementos.
        .RemoveAt()         remove o elemento de uma posicao especifica.
        .Sort()	            ordena os valores de forma ascendente.

        clone               nao tem, mas da para fazer assim: List<string> clone = new(aulas); // new List<string>(aulas);
        */

        //string AulaIntro = "Introducao as colecoes";
        //string AulaModelando = "Modelando a classe aula";
        //string AulaSets = "Trabalhando e conjuntos";

        ////List<String> Aulas = new List<String> {AulaIntro, AulaModelando, AulsSets};
        //List<String> aulas = new(); // new List<String>(); // new() - sempre posso usar o new desta forma para simplificar e nao ter que repetir o tipo;
        ////Aulas[0] = AulaIntro; // vazia, da erro
        //aulas.Add(AulaIntro);
        //aulas.Add(AulaModelando);
        //aulas.Add(AulaSets);

        ////ImprimirLista(Aulas);
        //Console.WriteLine($"A primeira aula e {aulas[0]}");
        //Console.WriteLine($"A primeira aula e {aulas.First()}");
        //Console.WriteLine($"A ultima aula e {aulas[aulas.Count()-1]}");
        //Console.WriteLine($"A ultima aula e {aulas.Last()}");

        //aulas[0] = "Trabalhando com listas";
        //Console.WriteLine("A primeira aula que contem Trabalhando : " + aulas.First(x => x.Contains("Trabalhando")));
        //Console.WriteLine("A ultima aula que contem Trabalhando : " + aulas.Last(x => x.Contains("Trabalhando")));
        //Console.WriteLine("A primeira aula que contem groselha : " + aulas.FirstOrDefault(x => x.Contains("groselha")));

        //aulas.Reverse();
        //ImprimirLista(aulas);
        //aulas.Reverse(); // reverse eh idempotente
        //ImprimirLista(aulas);

        //aulas.RemoveAt(aulas.Count-1);
        //ImprimirLista(aulas);

        //aulas.Add("Conclusao");
        //aulas.Sort();
        //ImprimirLista(aulas);

        //List<String> copia = aulas.GetRange(aulas.Count() -2, 2);
        //ImprimirLista(aulas, "imprimindo aulas");
        //ImprimirLista(copia, "imprimindo copia");

        //List<string> clone = new(aulas); // new List<string>(aulas); // new(aulas) - sempre posso usar o new desta forma para simplificar e nao ter que repetir o tipo;
        //ImprimirLista(clone, "imprimindo clone");
        #endregion

        #region listas_list_object
        //var AulaIntro = new Aula("Introducao as colecoes", 20);
        //var AulaModelando = new Aula("Modelando a classe aula", 18);
        //var AulaSets = new Aula("Trabalhando e conjuntos", 16);

        //List<Aula> aulas = new List<Aula>();

        //aulas.Add(AulaIntro);
        //aulas.Add(AulaModelando);
        //aulas.Add(AulaSets);

        //ImprimirListaObject(aulas);

        //aulas.Sort();
        //ImprimirListaObject(aulas);

        //aulas.Sort((aula1, aula2) => aula1.Tempo.CompareTo(aula2.Tempo)); // passando um comparison como parametro posso mudar a ordenacao
        //ImprimirListaObject(aulas);
        #endregion

        #region listas_list_somente_leitura
        //Curso csharpColecoes = new("Csharp collections", "Marcelo Oliveira"); // new Curso("Csharp collections", "Marcelo Oliveira");

        //csharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));
        //csharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
        //csharpColecoes.Adiciona(new Aula("Modelando colecoes", 19));

        ////ordenar lista de aulas
        ////csharpColecoes.Aulas.Sort(); // Aulas é uma lista projegida (ReadOnlyCollection) do tipo IList, e nao da suporte ao metodo .Sort()
        ////copiar a lista para outra lista que permita modificacao
        ////List<Aula> aulasCopia = new(csharpColecoes.Aulas); // new List<Aula>(csharpColecoes.Aulas);
        //var aulasCopia = new List<Aula>(csharpColecoes.Aulas);
        //aulasCopia.Sort();
        //ImprimirListaObject(aulasCopia); // code smell

        ////totalizar o tempo do curso
        //Console.WriteLine("");
        //Console.WriteLine($"Tempo total do curso: {csharpColecoes.TempoTotal}");

        ////imprimir detalhes do curso
        //Console.WriteLine("");
        //Console.WriteLine(csharpColecoes);

        #endregion

        #region conjuntos_set
        //sets = conjuntos
        //nao permite duplicidade
        //elementos nao tem ordenacao
        //conjunto eh mais rapido para buscar elementos, ver no stack overflow hashset vs list performance - utiliza tabela de espalhamento, então ocupa mais memoria
        #region conjuntos_set_introducao_basica
        //ISet<string> alunos = new HashSet<string>();
        //alunos.Add("Vanessa");
        //alunos.Add("Ana");
        //alunos.Add("Rafael");
        //alunos.Add("Priscila");
        //alunos.Add("Rafael"); // nao vai inserir, nao permite duplicidade
        //alunos.Add("Fabio");
        //alunos.Remove("Ana");
        //alunos.Add("Willian");
        //Console.WriteLine(string.Join(",", alunos));
        ////alunos.Sort(); // ISet nao implementa Sort()
        //List<string> alunosEmLista = new(alunos);
        //alunosEmLista.Sort();
        //Console.WriteLine(String.Join(",", alunosEmLista));
        #endregion
        #region conjuntos_set_com_modelo_cursos
        //Curso csharpColecoes = new Curso("Csharp colecoes", "Marcelo Oliveira");

        //csharpColecoes.Adiciona(new Aula("Trabalhand com lista" ,21));
        //csharpColecoes.Adiciona(new Aula("Criando uma aula" ,20));
        //csharpColecoes.Adiciona(new Aula("Modelando com colecoes" ,24));

        //Aluno a1 = new Aluno("Vanessa", 34672);
        //Aluno a2 = new Aluno("Ana", 5617);
        //Aluno a3 = new Aluno("Rafael", 17645);
        //Aluno a4 = new Aluno("Vanessa", 34672);

        //csharpColecoes.Matricula(a1);
        //csharpColecoes.Matricula(a2);
        //csharpColecoes.Matricula(a3);

        //ImprimirListaObjectGenerico<IList<Aluno>, Aluno>(csharpColecoes.Alunos, "Imprimindo os alunos matriculados");

        //Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado? {csharpColecoes.EstaMatriculado(a1)}");
        //Console.WriteLine($"O aluno a4 {a4.Nome} está matriculado? {csharpColecoes.EstaMatriculado(a4)}");

        //Console.WriteLine("a1 == a4?");
        //Console.WriteLine(a1 == a4);

        //Console.WriteLine("a1 Equals a4?");
        //Console.WriteLine(a1.Equals(a4));

        #endregion
        #endregion

        #region dicionarios_dictionary
        //um dictionary é uma estrutura de chave e valor, onde temos o tipo da chave e o tipo do valor, exemplo: <int, Aluno>
        //veja na classe curso que implementei um dictionary para conseguir fazer a busca rapida pela matricula
        //este é um benefício do dictionary, busca rapida
        //o dicionario nao permite adicionar um elemento na mesma chave com add, dá erro
        //mas pode-se substituir o valor usando variavel[indice] = valornovo. Esta sintaxe tanto pode incluir um  novo elemento se indice nao existir, ou substituir se ja existir
        //internamente usa codigo de dispersao da chave do elemento, e valores
        Curso csharpColecoes = new Curso("Csharp colecoes", "Marcelo Oliveira");

        Aluno a1 = new Aluno("Vanessa", 34672);
        Aluno a2 = new Aluno("Ana", 5617);
        Aluno a3 = new Aluno("Rafael", 17645);
        Aluno a4 = new Aluno("Vanessa", 34672);

        csharpColecoes.Matricula(a1);
        csharpColecoes.Matricula(a2);
        csharpColecoes.Matricula(a3);

        Console.WriteLine("Aluno 5617");
        Aluno aluno5617 = csharpColecoes.EstaMatriculadoDict(a2.NumeroMatricula);
        Console.WriteLine(aluno5617);

        Console.WriteLine("Aluno 989898");
        Aluno aluno989898 = csharpColecoes.EstaMatriculadoDict(989898);
        Console.WriteLine(aluno989898);
        #endregion

        #region lista_ligada_linkedlist
        // lista ligada - bom para lista grande onde insiro e removo elemento do meio da lista
        //nao precisa estar em ordem na memoria, pois cada elemento é um nó LinkedListNode, que sabe o nó anterior e posterior
        //
        //testados: AddFirst, AddLast, AddBefore, AddAfter, Next, Previous, Find, FindLast, Remove, Count, Contains, .Any()
        //testar: RemoveFirst, RemoveLast, Concat, Clear, CopyTo
        //LinkedList<string> dias = new LinkedList<string>(); // ao se pode já iniciar com os elementos definidos
        /*
        var d4 = dias.AddFirst("quarta");
        Console.WriteLine("d4.Value: " + d4.Value );
        var d2 = dias.AddBefore(d4, "segunda");
        Console.WriteLine("d2.Value: " + d2.Value);
        Console.WriteLine("d2.Next.Value: " + d2.Next.Value);
        Console.WriteLine("d4.Previous.Value: " + d4.Previous.Value);
        var d3 = dias.AddAfter(d2, "terca");
        Console.WriteLine("d3.Value: " + d3.Value);
        Console.WriteLine("d2.Next.Value: " + d2.Next.Value);
        Console.WriteLine("d4.Previous.Value: " + d4.Previous.Value);
        _ = dias.AddAfter(d4, "sexta"); // _ = descarta um valor retornado
        Console.WriteLine("d4.Next.Value: " + d4.Next.Value);
        var d6 = d4.Next;
        Console.WriteLine("d6.Value: " + d6.Value);
        var d7 = dias.AddAfter(d6, "sabado");
        var d5 = dias.AddBefore(d6, "quinta");
        var d1 = dias.AddBefore(d2, "domingo");
        foreach (var dia in dias) {
            Console.WriteLine(dia);  // no for acima dia recebe o Value
        }
        var quarta = dias.Find("quarta");
        Console.WriteLine("quarta: " + quarta.Value);
        dias.Remove("quarta");
        foreach (var dia in dias) {
            Console.WriteLine(dia);  // no for acima dia recebe o Value
        }
        dias.Remove(d5);
        foreach (var dia in dias) {
            Console.WriteLine(dia);  // no for acima dia recebe o Value
        }
        Console.WriteLine("dias..Count : " + dias.Count  );
        Console.WriteLine("dias contem quinta? " + dias.Contains("quinta"));
        Console.WriteLine("dias .Any() " + dias.Any());
        */
        #endregion

        #region plinha_stack
        // pilha/stack LAST IN FIRST OUT
        /*
        var navegador = new Navegador();
        navegador.NavegarPara("google.com");
        navegador.NavegarPara("caelum.com.br");
        navegador.NavegarPara("alura.com.br");
        navegador.Anterior();
        navegador.Anterior();
        navegador.Proximo();
        navegador.Proximo();
        navegador.Proximo();
        navegador.Anterior();
        navegador.Anterior();
        */
        #endregion

        #region fila_queue
        // fila/queue - FIRST IN FIRST OUT
        //static Queue<string> pedagio = new Queue<string>();
        //Enfileirar("VAN");
        //Enfileirar("KOMBI");
        //Enfileirar("GUINCHO");
        //Enfileirar("PICKUP");
        //Desenfileirar();
        #endregion
    }


    #region listas_list_object_metodos
    //private static void ImprimirListaObject(List<Aula> aulas, String texto = "") {
    //    if (texto != "") {
    //        Console.WriteLine();
    //        Console.WriteLine(texto);
    //    }

    //    foreach (var aula in aulas) {
    //        Console.WriteLine(aula);
    //    }
    //}
    #endregion

    #region listas_list_somente_leitura_metodos
    //private static void ImprimirListaObject(IList<Aula> aulas, String texto = "") // como a lista protegida retorna um IList, este metodo precisa receber IList
    //{
    //    if (texto != "") {
    //        Console.WriteLine();
    //        Console.WriteLine(texto);
    //    }

    //    foreach (var aula in aulas) {
    //        Console.WriteLine(aula);
    //    }
    //}
    #endregion

    #region conjuntos_set_com_modelo_cursos_metodos
    //public static void ImprimirListaObjectGenerico<T1, T2>(T1 lista, String texto = "") where T1 : IEnumerable<T2>
    //{
    //    if (texto != "")
    //    {
    //        Console.WriteLine();
    //        Console.WriteLine(texto);
    //    }

    //    foreach (var item in lista)
    //    {
    //        Console.WriteLine(item);
    //    }
    //}

    #endregion

    #region listas_list_metodos
    //private static void ImprimirLista(List<String> aulas, String texto = "")
    //{
    //    if (texto != "") {
    //        Console.WriteLine();
    //        Console.WriteLine(texto);
    //    }

    //    //foreach (var aula in aulas) { Console.WriteLine(aula); }

    //    //for (int i = 0; i < aulas.Count; i++) { Console.WriteLine(Aulas[i]); };

    //    aulas.ForEach(aula => Console.WriteLine(aula));
    //}
    #endregion

    #region fila_queue_metodos
    //private static void MostraFila()
    //{
    //    Console.WriteLine("Veiculos na fila: ");
    //    foreach (var veiculo in pedagio)
    //    {
    //        Console.WriteLine(veiculo);
    //    }
    //}

    //private static void Desenfileirar() {

    //    if (!pedagio.Any()) // or pedagio.Count > 0
    //    {
    //        return;
    //    }
    //    Console.WriteLine($"Caixa recebendo de : {pedagio.Peek()}");
    //    string veiculo = pedagio.Dequeue();
    //    Console.WriteLine($"Saiu da file: {veiculo}");
    //    MostraFila();
    //}

    //private static void Enfileirar(string veiculo) {
    //    Console.WriteLine($"Adicionando {veiculo} na fila.");
    //    pedagio.Enqueue(veiculo);
    //    MostraFila();
    //}
    #endregion
    }

#region plinha_stack_classe
// pilha/stack
/*
internal class Navegador {

    private string atual = "vazia";
    private readonly Stack<string> historicoAnterior = new Stack<string>();
    private readonly Stack<string> historicoProximo = new Stack<string>();

    private void MostraPaginaAtual()
    {
        Console.WriteLine($"Pagina atual: {atual}");
    }

    public Navegador() {
        MostraPaginaAtual();
    }

    internal void NavegarPara(string novaPagina) {
        historicoAnterior.Push(this.atual); // inserts an object at the top of the stack
        this.atual = novaPagina;
        MostraPaginaAtual();
    }

    internal void Anterior() {
        Console.WriteLine("");
        Console.WriteLine("anterior");
        Console.WriteLine("");
        Console.WriteLine($"Count before Pop() : {historicoAnterior.Count}"); // vazia, google.com, "caelum.com.br" // "alura.com.br" nao eh anterior, eh atual
        Console.WriteLine($"Max before Pop() : {historicoAnterior.Max()}"); // vazia - retorna no max por ser a mais longe a ser alcancada - LIFO - last in first out
        Console.WriteLine($"Min before Pop() : {historicoAnterior.Min()}"); // retorna caelum por er a primeira a ser alcancada - LIFO last in first out

        if (historicoAnterior.Count == 0) {
            Console.WriteLine("nao tem pagina anterior");
            return;
        }

        var removed = historicoAnterior.Pop(); // removes and returns the object at the top of the stack, remove caelum

        historicoProximo.Push(this.atual);

        Console.WriteLine($"removed: {removed}");
        Console.WriteLine($"Count after Pop() : {historicoAnterior.Count}");
        Console.WriteLine($"Max after Pop() : {historicoAnterior.Max()}");
        Console.WriteLine($"Min after Pop() : {historicoAnterior.Min()}");
        this.atual = removed;
        MostraPaginaAtual();
    }

    internal void Proximo() {
        Console.WriteLine("");
        Console.WriteLine("proximo");
        Console.WriteLine("");

        if (historicoProximo.Count == 0) {
            Console.WriteLine("nao tem pagina proxima");
            return;
        }

        historicoAnterior.Push(this.atual);

        this.atual = historicoProximo.Pop();
        MostraPaginaAtual();
    }
}
*/
#endregion

#region listas_list_object_classes
class Aula : IComparable {
    private string titulo;
    private int tempo;

    public Aula(string titulo, int tempo) {
        this.titulo = titulo;
        this.tempo = tempo;
    }

    public string Titulo { get => titulo; set => titulo = value; }
    public int Tempo { get => tempo; set => tempo = value; }

    public int CompareTo(object? aula)
    {
        var outraAula = aula as Aula;
        return this.titulo.CompareTo(outraAula.titulo);
    }

    public override string ToString() {
        return $"[titulo: {titulo} , tempo: {tempo} minutos]";
    }
}
#endregion

#region listas_list_somente_leitura_classes
//descomentar listas_list_object_classes
class Curso
{

    //propfull
    private string nome;
    private string instrutor;
    private IList<Aula> aulas; // IList nao da suporte ao metodo sort

    private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();

    //aluno deve ser um ISet. Aluno deve retornar um ReadOnlyCollection
    private ISet<Aluno> alunos = new HashSet<Aluno>();
    public IList<Aluno> Alunos
    {
        get {
            //return new ReadOnlyCollection<Aluno>(alunos); // nao funciona, Iset nao pode ser convertido em IList, só lista pode, entao fazer como abaixo
            return new ReadOnlyCollection<Aluno>(alunos.ToList());
        }
    }

    public Curso(string nome, string instrutor) {
        this.nome = nome;
        this.instrutor = instrutor;
        this.aulas = new List<Aula>();
    }

    public string Nome {
        get { return nome; }
        set { nome = value; }
    }
    public string Instrutor {
        get { return instrutor; }
        set { instrutor = value; }
    }

    //public List<Aula> Aulas { // o ReadOnlyCollection implementa um IList, entao tem que mudar o tipo da propriedade Aulas
    public IList<Aula> Aulas {
        //get { return aulas; } // code smell
        get { return new ReadOnlyCollection<Aula>(aulas); } // o ReadOnlyCollection implementa um IList, entao tem que mudar o tipo da propriedade Aulas
        //set { aulas = value; } // code smell
    }

    public void Adiciona(Aula aula) {
        this.aulas.Add(aula);
    }

    public int TempoTotal {
        get {
            return this.aulas.Sum(aula => aula.Tempo);
        }
    }

    public override string ToString() {
        return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
    }
    internal void Matricula(Aluno aluno) {
        alunos.Add(aluno);
        dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
    }

    public bool EstaMatriculado(Aluno aluno)
    {
        var estaMatriculado = alunos.Contains(aluno);
        return estaMatriculado;
    }

    public Aluno EstaMatriculadoDict(int numeroMatricula) {
        Aluno aluno = null;

        //aluno = dicionarioAlunos[numeroMatricula];
        //se nao achar dispara numeroMatricula exceção sem tratamento: System.Collections.Generic.KeyNotFoundException: A chave fornecida não estava presente no dicionário.

        dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);

        return aluno;
    }
}
#endregion

#region conjuntos_set_classes
//descomentar listas_list_somente_leitura_classes
#endregion
