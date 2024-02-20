using CSharpEstudando;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;

partial class Program {

    static void CSharpCollection2()
    {
        //Console.WriteLine("CSharpCollection2");

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
        //ISet<string> alunos = new SortedSet<string>(new ComparadorStringNaoSensitivoAoCaso()) // diferente do HashSet, o SortedSet é ordenado

        //ISet<string> alunos = new SortedSet<string>((x, y) => string.Compare(x, y, StringComparison.OrdinalIgnoreCase)) // nao funciona passar o comparador como funcao lambda por não ser um delegate o parametro

        IComparer<string> comparador = Comparer<string>.Create((x, y) => string.Compare(x, y, StringComparison.OrdinalIgnoreCase));

        //SortedSet armazena os valores como arvore binária balanceada, não contem chaves, não é coleção associativa, os valores são as próprias chaves
        /*
        IsSubsetOf          - se eh subconjunto
        IsSupersetOf        - se eh superconjunto
        SetEquals           - se eh igual
        IntersectWith       - so o que esta nas duas
        ExceptWith          - subtrais do primeiro o que nao esta no segundo - alunos.ExceptWith(outroconjunto)
        SymmetricExceptWith -  somente o que nao tem em comum nos dois
        UnionWith           - junta os dois
        */
        ISet<string> alunos = new SortedSet<string>(comparador) // assim funciona
        {
            "Vanessa Tonini", "Ana Losnak", "Rafael Nercessian", "Priscila Stuani"
        };

        alunos.Add("Rafael Rodolfo");
        alunos.Add("Fabio Gushiken");
        alunos.Add("FABIO GUSHIKEN");

        foreach (var aluno in alunos) {
            Console.WriteLine(aluno);
        }

        ISet<string> outroContunto = new HashSet<string>()
        {
            "Vanessa Tonini", "Ana Losnak", "Rafael Nercessian", "Este nao tem"
        };
        var ehSubset = outroContunto.IsSubsetOf(alunos);
        Console.WriteLine($"outroContunto IsSubsetOf alunos: {ehSubset}");
        var ehSuperConjunto = alunos.IsSupersetOf(outroContunto);
        Console.WriteLine($"alunos IsSupersetOf outroContunto: {ehSuperConjunto}");
        var ehigual = alunos.SetEquals(outroContunto);
        Console.WriteLine($"alunos SetEquals outroContunto: {ehSuperConjunto}");

        outroContunto.Remove("Este nao tem");

        ehSubset = outroContunto.IsSubsetOf(alunos);
        Console.WriteLine($"outroContunto IsSubsetOf alunos: {ehSubset}");
        ehSuperConjunto = alunos.IsSupersetOf(outroContunto);
        Console.WriteLine($"alunos IsSupersetOf outroContunto: {ehSuperConjunto}");

        Console.WriteLine("");
        Console.WriteLine("alunos");
        foreach (var aluno in alunos) {
            Console.WriteLine(aluno);
        }

        Console.WriteLine("");
        Console.WriteLine("alunos IntersectWith outroContunto");
        alunos.IntersectWith(outroContunto);
        foreach (var aluno in alunos) {
            Console.WriteLine(aluno);
        }

        Console.WriteLine("");
        Console.WriteLine("alunos SymmetricExceptWith outroContunto");
        outroContunto.Add("Este nao tem");
        alunos.SymmetricExceptWith(outroContunto);
        foreach (var aluno in alunos) {
            Console.WriteLine(aluno);
        }

        Console.WriteLine("");
        Console.WriteLine("alunos UnionWith outroContunto");
        alunos.UnionWith(outroContunto);
        foreach (var aluno in alunos) {
            Console.WriteLine(aluno);
        }
        #endregion
    }

    //#region listas_ _metodos
    //#endregion

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
        return string.Compare(string1, string2, StringComparison.InvariantCultureIgnoreCase); // todos funcionam, maneiras diferentes de implementar, acredito que este seja melhor
    }
}

#region listas_sortedlist_metodos_classe
#endregion
