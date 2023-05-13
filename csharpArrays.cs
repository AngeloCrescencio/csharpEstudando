using System;
using System.Text;

partial class Program
{

    //testando se salva no replit.com  
    static void CSharpArrays()
    {
        Console.WriteLine("CSharpArrays");

        int[] notas;
        notas = new int[2];
        notas[0] = 9;
        notas[1] = 10;
        Console.WriteLine($"Nota 1 : {notas[0]} Nota 2 : {notas[1]}");

        int[] valores = new int[4];
        valores[0] = 90;
        valores[1] = 100;
        valores[2] = 110;
        valores[3] = 120;

        for (int i = 0; i < valores.Length; i++)
        {
            Console.WriteLine($"Valor {i} : {valores[i]}");
        }
    }
}