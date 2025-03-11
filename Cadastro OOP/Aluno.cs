using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_OOP
{
    class Aluno
    {
        public string Nome;
        public string Email;
        public string Curso;
        public int Matricula;

        public Aluno(string nome, string email, string curso, int matricula)
        {
            Nome = nome;
            Email = email;
            Curso = curso;
            Matricula = matricula;
        }

        public void Informacoes()
        {
            Console.WriteLine($"Nome: {Nome}\nE-mail: {Email}\nCurso: {Curso}\nNúmero da Matrícula: {Matricula}");
            Console.WriteLine("----------------------------------------");
        }
    }
}
