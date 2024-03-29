﻿partial class Program {

    static void CSharpArrays() {
        //Console.WriteLine("CSharpArrays");

        #region array_simples
        //// >>>>> ver a diferença entre GetLength e Lenght e entre CopyTo e Clone, aprender e documentar com exemplos
        ///*
        //Propriedade/Método  Descrição
        //.Length	            retorna o número de elementos.
        //.GetLength	        retorna o números de elementos.
        //.Rank	            retorna o número de dimensões.
        //.SetValue           atribui valor a um elemento.
        //.GetValue	        retorna o conteúdo/valor de um elemento pelo índice.
        //.Exists	            verifica se existe ou não um elemento.
        //.IndexOf	        encontra a primeira ocorrência de um elemento.
        //.LastIndexOf	    encontra a última ocorrência de um elemento.
        //.Sort	            ordena os valores de forma ascendente.
        //.Reverse	        inverte a ordem de elementos.
        //.CopyTo	            cria uma cópia de todos os valores.
        //.Clone	            cria uma cópia.
        //Clear	            limpa todas as posições.
        //ConstrainedCopy     
        //ConvertAll          
        //*/

        //int[] notas;
        //notas = new int[2];
        //notas[0] = 9;
        //notas[1] = 10;
        //Console.WriteLine($"Nota 1 : {notas[0]} Nota 2 : {notas.GetValue(1)}");

        //int[] valores = new int[5];
        //valores[0] = 90;
        //valores[1] = 100;
        //valores[2] = 110;
        //valores[3] = 120;

        //valores.SetValue(130, 4);

        //Console.WriteLine($"Valores GetLength : {valores.GetLength(0)}"); // 0 = numero da dimensao
        //Console.WriteLine($"Valores Length : {valores.Length}");

        //for (int i = 0; i < valores.Length; i++) {
        //    Console.WriteLine($"Valor {i} : {valores[i]}");
        //}

        //int[,] numeros = new int[2, 2];

        //Console.WriteLine($"Dimensoes de numeros : {numeros.Rank}");

        //double[] valoresDouble = { 2.6, 9.7, 7.5, 1.8 };
        //string[] nomes = new string[7] { "Angelo", "Luiz", "Solange", "João", "Zulmira", "Solange", "João" };

        //foreach (String nome in nomes) { Console.WriteLine(nome); };

        //Console.WriteLine("Existe Zulmira em nomes : " + Array.Exists(nomes, el => el == "Zulmira"));
        //Console.WriteLine("Existe nome iniciando com L : " + Array.Exists(nomes, el => el.StartsWith("L")));
        //Console.WriteLine("Existe nome terminando com o : " + Array.Exists(nomes, el => el.EndsWith("o")));

        //Console.WriteLine("Primeira posição de Solange : " + Array.IndexOf(nomes, "Solange"));
        //Console.WriteLine("Primeira posição de Solange : " + Array.LastIndexOf(nomes, "Solange"));

        //Array pesquisa = Array.CreateInstance(typeof(double), 7);
        //// é a mesma coisa que Array pesquisa = new double[7];
        //pesquisa.SetValue(8.3, 0);
        //pesquisa.SetValue(9.2, 1);
        //pesquisa.SetValue(9.9, 2);
        //pesquisa.SetValue(8.5, 3);
        //pesquisa.SetValue(8.8, 4);
        //pesquisa.SetValue(10.0, 5);
        //pesquisa.SetValue(7.0, 6);

        //Console.WriteLine("pesquisa em ordem crescente");
        //Array.Sort(pesquisa);
        //foreach (double valorPesquisa in pesquisa) { Console.WriteLine(valorPesquisa); };

        //Console.WriteLine("pesquisa em ordem decrescente");
        //Array.Reverse(pesquisa);
        //foreach (double valorPesquisa in pesquisa) { Console.WriteLine(valorPesquisa); };

        //Console.WriteLine("Copiando nomes em frutas");
        //string[] frutas = new string[17];
        //frutas.SetValue("Banana", 0);
        //frutas.SetValue("Laranja", 1);
        //frutas.SetValue("Maça", 2);
        //frutas.SetValue("Goiaba", 3);

        //nomes.CopyTo(frutas, 2);

        //foreach (string fruta in frutas) { Console.WriteLine(fruta); };

        //// como eu não tipifiquei o resultado como array, o c# cria entende o resultado como object, por isso a linha abaixo falha, pois object não tem .Clone(),
        //// mas ainda assim cloneNomes1 é criado como array
        //var cloneNomes1 = nomes.Clone();
        ////var cloneNomes2 = (string[])cloneNomes1.Clone();
        //var cloneNomes2 = (string[])nomes.Clone();
        //var cloneNomes3 = (string[])cloneNomes2.Clone();

        //Console.WriteLine("tipo de cloneNomes 1 : " + cloneNomes1.GetType());
        //Console.WriteLine("tipo de cloneNomes 2 : " + cloneNomes2.GetType());
        //Console.WriteLine("tipo de cloneNomes 3 : " + cloneNomes3.GetType());
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
    }
}
