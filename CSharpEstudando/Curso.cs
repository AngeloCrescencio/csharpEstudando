using CSharpEstudando;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEstudando
{
    public class Curso
    {
        //propfull
        private string nome;
        private string instrutor;
        private IList<Aula> aulas; // IList nao da suporte ao metodo sort

        private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();

        //alunos deve ser um ISet. Alunos deve retornar um ReadOnlyCollection
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get {
                //return new ReadOnlyCollection<Aluno>(alunos); // nao funciona, Iset nao pode ser convertido em IList, só lista pode, entao fazer como abaixo
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        public Curso(string nome, string instrutor) {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        public string Nome {
            get { return nome; }
            set { nome = value; }
        }
        public string Instrutor {
            get { return instrutor; }
            set { instrutor = value; }
        }

        //public List<Aula> Aulas { // o ReadOnlyCollection implementa um IList, entao tem que mudar o tipo da propriedade Aulas
        public IList<Aula> Aulas {
            //get { return aulas; } // code smell
            get { return new ReadOnlyCollection<Aula>(aulas); } // o ReadOnlyCollection implementa um IList, entao tem que mudar o tipo da propriedade Aulas
            //set { aulas = value; } // code smell
        }

        public void Adiciona(Aula aula) {
            this.aulas.Add(aula);
        }

        public int TempoTotal {
            get {
                return this.aulas.Sum(aula => aula.Tempo);
            }
        }

        public override string ToString() {
            return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
        }
        internal void Matricula(Aluno aluno) {
            alunos.Add(aluno);
            dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            var estaMatriculado = alunos.Contains(aluno);
            return estaMatriculado;
        }

        public Aluno EstaMatriculadoDict(int numeroMatricula) {
            Aluno aluno = null;

            //aluno = dicionarioAlunos[numeroMatricula];
            //se nao achar dispara numeroMatricula exceção sem tratamento: System.Collections.Generic.KeyNotFoundException: A chave fornecida não estava presente no dicionário.

            dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);

            return aluno;
        }
    }
}
