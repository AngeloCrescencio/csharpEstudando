using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEstudando
{
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
}
