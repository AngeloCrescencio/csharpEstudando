partial class Program
{
    static void Main(string[] args)
    {
        //CSharpArrays(); // arra simples, array multidimensional, array dentado

        /*
        list        - List de valores primitivos, List de objetos, List somente leitura IList ReadOnlyCollection
        conjunto    - ISet HashSet
        dicionario  - IDictionary Dictionary
        lista       - ligada LinkedList
        pilha       - Stack
        fila        - Queue
        */
        //CSharpCollection1();

        /*
        dicionario ordenado - IDictionary SortedList        - tem uma estrutura de chaves em uma lista IList<TKey> (automáticamente ordenada), e os valores ficam em uma lista separada IList<TValue>
        dicionario ordenado - IDictionary SortedDictionary  - trabalha com um KeyCollection armazenadas em uma estrutura de arvore binaria, e as chaves apontam para um ValueCollection
        conjunto ordenado   - ISet SortedSet                - armazena os valores como arvore binária balanceada, não contem chaves, não é coleção associativa, os valores são as próprias chaves
        */
        CSharpCollection2();

        //CSharpLinqObject();

        //CSharpEntityFrameworkCore0();
        //CSharpEntityFrameworkCore1();
        //CSharpEntityFrameworkCore2();

        //CSharpLinqEntity1();
        //CSharpLinqEntity2();
    }
}
