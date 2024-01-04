partial class Program {

    #region fila_queue_variaveis
    // fila/queue
    //static Queue<string> pedagio = new Queue<string>();
    #endregion

    static void CSharpCollection1()
    {
        Console.WriteLine("CSharpCollection1");

        #region listas_list
        // listas
        #endregion

        #region conjuntos_set
        // sets
        #endregion

        #region dicionarios_dictionary
        // dicionarios
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