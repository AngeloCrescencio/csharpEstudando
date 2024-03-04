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
        ////ISet<string> alunos = new SortedSet<string>(new ComparadorStringNaoSensitivoAoCaso()); // diferente do HashSet, o SortedSet é ordenado

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

        #region convetendo_e_enumerando_colecoes
        ////conversao de string para object
        //string strTitulo = "meses";
        //object objTitulo = strTitulo; // string herda de object, da pra fazer
        //Console.WriteLine("string para object ok");
        //Console.WriteLine(objTitulo);
        //Console.WriteLine();

        //Console.WriteLine("array de string para array de obj, nao recomendado");
        //IList<string> listMeses = new List<string>()
        //{
        //    "Janeiro","Fevereiro","Março","Abril","Maio","Junho","Julho","Agosto","Setembro","Outubro","Novembro","Dezembro"
        //};
        ////IList<Object> objMeses = listMeses; // nao faz conversao implicita pois Ilist nao permite converter IList de String para IList de Object

        //string[] arrayMeses = new string[] { "Janeiro","Fevereiro","Março","Abril","Maio","Junho","Julho","Agosto","Setembro","Outubro","Novembro","Dezembro" };
        //object[] objMeses = arrayMeses; // ambos sao System.String[] , string[] herda de array, objet[] herda de array, array herda de object, mas funciona pela covariancia
        //Console.WriteLine(arrayMeses);
        //Console.WriteLine(objMeses);
        //foreach (var mes in objMeses) {
        //    Console.WriteLine(mes);
        //}

        //Console.WriteLine();
        //objMeses[0] = "PRIMEIRO MES";
        //Console.WriteLine(objMeses[0]);
        //Console.WriteLine();
        ////problema da covariancia do array, o array sendo de object deveria poder atribuir outros tipos, mas no .net framework nao esta funcionando, nao usar covariancia de array x obj
        ////Console.WriteLine();
        ////objMeses[0] = 12345; // nao funciona, deixa em tempo de codificacao mas da erro ao executar, apesar de estar declarado como array de obj, esta armazendando array de string System.String[]
        ////Console.WriteLine(objMeses[0]);

        //Console.WriteLine("array de string para array ienumerable de string, ok");
        //// IEnumerable<out T>, logo é covariante, pode guardra object...ou string..., alem disso o out garante que o tipo não é modificado pela interface, então a covariancia é segura
        //IEnumerable<object> enumObj = listMeses; // listMeses List<string>, covariancia possivel e sem problemas
        //foreach (var item in enumObj) {
        //    Console.WriteLine(item);
        //}
        ////enumObj[0] = 12345; // o compilador já não deixa, em tempo de codificacao ja aponta erro, o IEnumerable nao possui indexador, entao nao consegue mudar assim
        #endregion

        #region o_laco_foreach
        //Console.WriteLine("foreach e List<string>");
        //var listMeses = new List<string>()
        //{
        //    "Janeiro","Fevereiro","Março","Abril","Maio","Junho","Julho","Agosto","Setembro","Outubro","Novembro","Dezembro"
        //};
        ////foreach implementa um IEnumerable<t>, que tem um Enumerator, este Enumerator é um struct que tem um Current (elemento atual) e o metodo MoveNext() que é usado para mover para o proximo
        ////chama enumerador
        ////posiciona no indice -1
        ////quando o foreach inicia, ele utiliza o metodo MoveNext, que move para indice 0, que é janeiro
        ////vai passando pelo codigo, depois movenext, quando chega no ultimo elemento fica fora da lista e termina o laço foreach
        ////a colacao ter uma versao, o foreach verifica se mudou a versao da colecao, e da erro se mudar
        //foreach (var mes in listMeses) {
        //    //mes = mes.ToUpper(); // nao deixa modificar o iterator do foreach
        //    //listMeses[0] = listMeses[0].ToUpper(); // nao da erro ao codificar, mas da erro ao executar, pois dentro do indexador tem um codigo que tem a versão da colecao
        //    Console.WriteLine(mes);
        //}

        //Console.WriteLine();
        //Console.WriteLine("foreach e string[]");
        //var arrayMeses = new string[]
        //{
        //    "Janeiro","Fevereiro","Março","Abril","Maio","Junho","Julho","Agosto","Setembro","Outubro","Novembro","Dezembro"
        //};
        ////transforma em laço for for (int i = 0; i < arrayMeses.Lenght; i++) { var mes = arrayMeses[i]
        //foreach (var mes in arrayMeses) {
        //    arrayMeses[0] = arrayMeses[0].ToUpper(); // nao funciona porque anets de executar este meu codigo, fez o var mes = arrayMeses[i]
        //    Console.WriteLine(mes);
        //    Console.WriteLine(mes.ToUpper());
        //}
        #endregion
    }

    //#region listas_ _metodos
    //#endregion
}
