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
        //SortedList trabalha com duas listas, um IList de chaves e um IList de valores, vai ordenando as chaves conforme vai mantendo a lista
        //SordetDictionary trabalha com um KeyCollection e um ValueCollection
        //as chaves dp KeyColection são armazenadas em uma estrutura de arvore binaria, como uma linkedlist, onde se sabe o anterior e o posterior, esta arvore tem balanceamento
        //as chaves apontam para a ValueCollection
        //para acrescentar e excluir elementos nao precisa deslocar os demais, como no sortedlist que usa uma lista, dai se inclui ou exclui um tem que mover os elementos
        IDictionary<string, Aluno> sortedAlunos = new SortedDictionary<string, Aluno>();

        sortedAlunos.Add("VP", new Aluno("Vanessa", 34672));
        sortedAlunos.Add("AL", new Aluno("Ana", 5617));
        sortedAlunos.Add("RN", new Aluno("Rafael", 17646));
        sortedAlunos.Add("WM", new Aluno("Wanderson", 11287));

        Console.WriteLine("");
        foreach (var aluno in sortedAlunos) {
            Console.WriteLine(aluno);
        }
        #endregion
    }

    //#region listas_ _metodos
    //#endregion

    }

#region listas_sortedlist_metodos_classe
#endregion
