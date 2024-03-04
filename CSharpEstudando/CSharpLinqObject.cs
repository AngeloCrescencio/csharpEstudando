using CSharpEstudando;

partial class Program {
    static void CSharpLinqObject()
    {
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

        string[] seq1 = { "janeiro", "fevereiro", "março" };
        string[] seq2 = { "fevereiro", "MARÇO", "abril" };

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
}
