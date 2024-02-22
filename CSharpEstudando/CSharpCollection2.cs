using CSharpEstudando;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;

partial class Program {

    static void CSharpCollection2()
    {
        //Console.WriteLine("CSharpCollection2");

        /*
        A classe genérica SortedDictionary é uma árvore de busca binária com "comportamento de recuperação de dados" expresso na notação de complexidade O(log n), onde n é o número de elementos
        no dicionário.

        Sob esse aspecto, ela é similar à classe genérica SortedList, e as duas possuem complexidade de recuperação equivalente: O(log n)

        Porém, SortedDictionary possui operações de inserção e remoção mais rápidas, porque essas operações em SortedDictionary são O(log n), enquanto as mesmas operações
        no SortedList possuem complexidade O(n).
        */

        #region listas_sortedlist
        // Dictionary<Tkey, TValue> nao eh ordenado, armazena chaves de maneira nao ordenada, utiliza um hash
        //IDictionary<string, Aluno> dicAlunos = new Dictionary<string, Aluno>();

        //dicAlunos.Add("VP", new Aluno("Vanessa", 34672));
        //dicAlunos.Add("AL", new Aluno("Ana", 5617));
        //dicAlunos.Add("RN", new Aluno("Rafael", 17646));
        //dicAlunos.Add("WM", new Aluno("Wanderson", 11287));

        //foreach (var aluno in dicAlunos) {
        //    Console.WriteLine(aluno);
        //}

        //dicAlunos.Remove("AL");
        //dicAlunos.Add("MO", new Aluno("Marcelo", 12345));

        //Console.WriteLine("");
        //foreach (var aluno in dicAlunos) {
        //    Console.WriteLine(aluno);
        //}

        //// Para ordenar precisa usar o SortedList<TKey, TValue>, SortedList não é um IList , e sim um IDictionary
        //// Tem uma estrutura de chaves em uma lista IList<TKey> (automáticamente ordenada), e os valores ficam em uma lista separada IList<TValue>
        //IDictionary<string, Aluno> sortedAlunos = new SortedList<string, Aluno>();

        //sortedAlunos.Add("VP", new Aluno("Vanessa", 34672));
        //sortedAlunos.Add("AL", new Aluno("Ana", 5617));
        //sortedAlunos.Add("RN", new Aluno("Rafael", 17646));
        //sortedAlunos.Add("WM", new Aluno("Wanderson", 11287));

        //Console.WriteLine("");
        //foreach (var aluno in sortedAlunos) {
        //    Console.WriteLine(aluno);
        //}
        #endregion

        #region listas_sorteddictionary
        //SortedDictionary difere do SortedList em sua implementacao interna
        //SortedList trabalha com duas listas, um IList de chaves e um IList de valores, vai ordenando as chaves conforme  vai mantendo a lista
        //SordetDictionary trabalha com um KeyCollection e um ValueCollection
        //as chaves da KeyColection são armazenadas em uma estrutura de arvore binaria, como uma linkedlist, onde se sabe o anterior e o posterior, esta arvore tem balanceamento
        //as chaves apontam para a ValueCollection
        //para acrescentar e excluir elementos nao precisa deslocar os demais, como no sortedlist que usa uma lista, onde ai se inclui ou exclui um tem que mover os elementos
        //IDictionary<string, Aluno> sortedAlunos = new SortedDictionary<string, Aluno>();

        //sortedAlunos.Add("VP", new Aluno("Vanessa", 34672));
        //sortedAlunos.Add("AL", new Aluno("Ana", 5617));
        //sortedAlunos.Add("RN", new Aluno("Rafael", 17646));
        //sortedAlunos.Add("WM", new Aluno("Wanderson", 11287));

        //Console.WriteLine("");
        //foreach (var aluno in sortedAlunos) {
        //    Console.WriteLine(aluno);
        //}
        #endregion

        #region listas_sortedset
        ////ISet<string> alunos = new SortedSet<string>(new ComparadorStringNaoSensitivoAoCaso()) // diferente do HashSet, o SortedSet é ordenado

        ////ISet<string> alunos = new SortedSet<string>((x, y) => string.Compare(x, y, StringComparison.OrdinalIgnoreCase)) // nao funciona passar o comparador como funcao lambda por não ser um delegate o parametro

        //IComparer<string> comparador = Comparer<string>.Create((x, y) => string.Compare(x, y, StringComparison.OrdinalIgnoreCase));

        ////SortedSet armazena os valores como arvore binária balanceada, não contem chaves, não é coleção associativa, os valores são as próprias chaves
        ///* metodos que funcionam com Iset, ou seja, funcionam para HashSet e para SortedSet
        //IsSubsetOf          - se eh subconjunto
        //IsSupersetOf        - se eh superconjunto
        //SetEquals           - se eh igual
        //IntersectWith       - so o que esta nas duas
        //ExceptWith          - subtrais do primeiro o que nao esta no segundo - alunos.ExceptWith(outroconjunto)
        //SymmetricExceptWith -  somente o que nao tem em comum nos dois
        //UnionWith           - junta os dois
        //*/
        //ISet<string> alunos = new SortedSet<string>(comparador) // assim funciona
        //{
        //    "Vanessa Tonini", "Ana Losnak", "Rafael Nercessian", "Priscila Stuani"
        //};

        //alunos.Add("Rafael Rodolfo");
        //alunos.Add("Fabio Gushiken");
        //alunos.Add("FABIO GUSHIKEN");

        //foreach (var aluno in alunos) {
        //    Console.WriteLine(aluno);
        //}

        //ISet<string> outroContunto = new HashSet<string>()
        //{
        //    "Vanessa Tonini", "Ana Losnak", "Rafael Nercessian", "Este nao tem"
        //};
        //var ehSubset = outroContunto.IsSubsetOf(alunos);
        //Console.WriteLine($"outroContunto IsSubsetOf alunos: {ehSubset}");
        //var ehSuperConjunto = alunos.IsSupersetOf(outroContunto);
        //Console.WriteLine($"alunos IsSupersetOf outroContunto: {ehSuperConjunto}");
        //var ehigual = alunos.SetEquals(outroContunto);
        //Console.WriteLine($"alunos SetEquals outroContunto: {ehSuperConjunto}");

        //outroContunto.Remove("Este nao tem");

        //ehSubset = outroContunto.IsSubsetOf(alunos);
        //Console.WriteLine($"outroContunto IsSubsetOf alunos: {ehSubset}");
        //ehSuperConjunto = alunos.IsSupersetOf(outroContunto);
        //Console.WriteLine($"alunos IsSupersetOf outroContunto: {ehSuperConjunto}");

        //Console.WriteLine("");
        //Console.WriteLine("alunos");
        //foreach (var aluno in alunos) {
        //    Console.WriteLine(aluno);
        //}

        //Console.WriteLine("");
        //Console.WriteLine("alunos IntersectWith outroContunto");
        //alunos.IntersectWith(outroContunto);
        //foreach (var aluno in alunos) {
        //    Console.WriteLine(aluno);
        //}

        //Console.WriteLine("");
        //Console.WriteLine("alunos SymmetricExceptWith outroContunto");
        //outroContunto.Add("Este nao tem");
        //alunos.SymmetricExceptWith(outroContunto);
        //foreach (var aluno in alunos) {
        //    Console.WriteLine(aluno);
        //}

        //Console.WriteLine("");
        //Console.WriteLine("alunos UnionWith outroContunto");
        //alunos.UnionWith(outroContunto);
        //foreach (var aluno in alunos) {
        //    Console.WriteLine(aluno);
        //}
        #endregion

        #region array_multidimencional
        //string[,] resultados = new string[4,3]; // colocacao, copa
        ////{
        ////  { "Alemanha", "Espanha", "Itália" }, 
        ////  { "Argentina", "Holanda", "França"}, 
        ////  { "Holanda", "Alemanha", "Alemanha" }
        ////};

        ////vai dar o mesmo resultado como se tivesse feito da forma anterior ao iterar para exibir
        //resultados[0, 0] = "Alemanha";
        //resultados[1, 0] = "Argentina";
        //resultados[2, 0] = "Holanda";
        //resultados[3, 0] = "Brasil";

        //resultados[0, 1] = "Espanha";
        //resultados[1, 1] = "Holanda";
        //resultados[2, 1] = "Alemanha";
        //resultados[3, 1] = "Uruguai";

        //resultados[0, 2] = "Itália";
        //resultados[1, 2] = "França";
        //resultados[2, 2] = "Alemanha";
        //resultados[3, 2] = "Portugal";

        //// interessante notar que imprime o array multidimensional em sequencia, como se fosse um array simples
        ////porque o array multidimencional armazena seus valores em sequencia, como se fosse um array simples
        ////foreach (var selecao in resultados) {
        ////    Console.WriteLine(selecao);
        ////}

        //Console.WriteLine($"elementos da dimensao 0 : {resultados.GetUpperBound(0)}");
        //Console.WriteLine($"elementos da dimensao 1 : {resultados.GetUpperBound(1)}");
        //Console.WriteLine("");

        //for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++) {
        //    int ano = 2014 - (copa * 4);
        //    Console.Write(ano.ToString().PadRight(15));
        //}

        //for (int colocacao = 0; colocacao <= resultados.GetUpperBound(0); colocacao++) {
        //    Console.WriteLine("");
        //    for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++) {
        //        Console.Write(resultados[colocacao, copa].PadRight(15));
        //    }
        //}
        #endregion

        #region jagged_array_array_dentado
        //string[][] familias = new string[3][];
        ////{
        ////    {"Fred", "Vilma", "Pedrita"},
        ////    {"Homer", "Margie", "Lisa", "Barth", "Magie"},
        ////    {"Florinda", "Kiko"}
        ////};

        //familias[0] = new string[] { "Fred", "Vilma", "Pedrita" };
        //familias[1] = new string[] { "Homer", "Margie", "Lisa", "Barth", "Magie" };
        //familias[2] = new string[] { "Florinda", "Kiko" };

        //foreach (var familia in familias) {
        //    Console.WriteLine(string.Join(",", familia));
        //}
        #endregion

        #region consultando_com_linq1
        /*
        .Where
        .OrderBy
        .Select
        .Take
        .Skip
        .TakeWhile
        .SkipWhile
        .StartsWith
        .EndsWith
        .Contains
        .ToUpper
        .Concat - junta tudo
        .Union - junta como se usasse distinct, despreza os iguais (se quiser ignorar o caso usar comparador)
        .Intersect - somente o que tem nos dois
        .Except - o que tem em uma (seq1) mas nao tem na outra (seq2)
        StringComparer. - usa comparadores de string, por exemplo, para nao considerar diferença entre maiuscula a minuscula
        */
        List<Mes> meses = new List<Mes>
        {
            new Mes("Janeiro", 31),
            new Mes("Fevereiro", 28),
            new Mes("Março", 31),
            new Mes("Abril", 30),
            new Mes("Maio", 31),
            new Mes("Junho", 30),
            new Mes("Julho", 31),
            new Mes("Agosto", 31),
            new Mes("Setembro", 30),
            new Mes("Outubro", 31),
            new Mes("Novembro", 30),
            new Mes("Dezembro", 31)
        };

        //requisito : listar os meses que tem 31 dias, mostrar os nomes em maiúsculo, ordenado de forma ascendente

        IEnumerable<string> resultado = meses.Where(x => x.Dias == 31).OrderBy(x => x.Nome.ToUpper()).Select(x => x.Nome.ToUpper());

        foreach (var mes in resultado) {
            Console.WriteLine(mes);
        }
        Console.WriteLine("");
        foreach (var mes in meses.Where(x => x.Dias == 31).OrderBy(x => x.Nome.ToUpper()).Select(x => x.Nome.ToUpper())) {
            Console.WriteLine(mes);
        }

        //requisito : listar o primeiro trimestre
        var trimestre1 = meses.Take(3);
        Console.WriteLine("");
        Console.WriteLine("listar o primeiro trimestre");
        foreach (var mes in trimestre1) {
            Console.WriteLine(mes);
        }

        //requisito : listar os meses depois do o primeiro trimestre
        var trimestresDeopisDoPrimeiro = meses.Skip(3);
        Console.WriteLine("");
        Console.WriteLine("listar os meses depois do o primeiro trimestre");
        foreach (var mes in trimestresDeopisDoPrimeiro) {
            Console.WriteLine(mes);
        }

        //requisito : listar os meses do terceiro trimestre
        var trimestres3 = meses.Skip(6).Take(3);
        Console.WriteLine("");
        Console.WriteLine("listar os meses do terceiro trimestre");
        foreach (var mes in trimestres3) {
            Console.WriteLine(mes);
        }

        //requisito : pegar meses ate o mes que inicie com a letra s
        var mesesates = meses.TakeWhile(x => !x.Nome.ToUpper().StartsWith("S"));
        Console.WriteLine("");
        Console.WriteLine("pegar meses ate o mes que inicie com a letra s");
        foreach (var mes in mesesates) {
            Console.WriteLine(mes);
        }

        //requisito : pegar meses a partir do mes que se inicie com s
        var mesesaapartirs = meses.SkipWhile(x => !x.Nome.ToUpper().StartsWith("S"));
        Console.WriteLine("");
        Console.WriteLine("pegar meses a partir do mes que se inicie com s");
        foreach (var mes in mesesaapartirs) {
            Console.WriteLine(mes);
        }

        Console.ReadKey();
        Console.Clear();

        string[] seq1 = {"janeiro","fevereiro","março"};
        string[] seq2 = {"fevereiro","MARÇO","abril"};

        var setConcat = seq1.Concat(seq2);
        Console.WriteLine("");
        Console.WriteLine("seq1.Concat(seq2)");
        foreach (var mes in setConcat) {
            Console.WriteLine(mes);
        }

        var setUnion = seq1.Union(seq2);
        Console.WriteLine("");
        Console.WriteLine("seq1.Union(seq2)");
        foreach (var mes in setUnion) {
            Console.WriteLine(mes);
        }

        var setUnionComparador = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
        Console.WriteLine("");
        Console.WriteLine("seq1.Union(seq2) mas com comparador para nao diferenciar caso");
        foreach (var mes in setUnionComparador) {
            Console.WriteLine(mes);
        }

        var setIntersect = seq1.Intersect(seq2);
        Console.WriteLine("");
        Console.WriteLine("seq1.Intersect(seq2)");
        foreach (var mes in setIntersect) {
            Console.WriteLine(mes);
        }

        var setExcept = seq1.Except(seq2);
        Console.WriteLine("");
        Console.WriteLine("seq1.Except(seq2)");
        foreach (var mes in setExcept) {
            Console.WriteLine(mes);
        }
        #endregion
    }

    //#region listas_ _metodos
    //#endregion

}

public class Mes
 {
    public Mes(string nome, int dias) {
        Nome = nome;
        Dias = dias;
    }

    public string Nome { get; private set; }
    public int Dias { get; private set; }

    public override string ToString() {
        return $"Mes: {this.Nome}, dias: {this.Dias}";
    }
}

public class ComparadorStringNaoSensitivoAoCaso : IComparer<string> {
    public int Compare(string? string1, string? string2) {

        if (string1 == null && string2 == null)
            return 0;
        else if (string1 == null)
            return -1;
        else if (string2 == null)
            return 1;

        //return string1.ToLower().CompareTo(string2.ToLower());     // todos funcionam, maneiras diferentes de implementar
        //return string.Compare(string1.ToLower(), string2.ToLower()); // todos funcionam, maneiras diferentes de implementar, acredito que este seja melhor
        return string.Compare(string1, string2, StringComparison.InvariantCultureIgnoreCase); // todos funcionam, maneiras diferentes de implementar, acredito que este seja ainda melhor
    }
}

#region listas_sortedlist_metodos_classe
#endregion
