using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_OOP
{
    class Verificar
    {
        Terminal terminal = new();
        public string Nome(string nome)
        {
            while (nome.Length == 0)
            {
                Console.Clear();
                terminal.MensagemErro();
                Console.WriteLine("Digite o nome do aluno");
                nome = Console.ReadLine();
            }
            return nome;
        }
        public string Email(string email)
        {
            while (!email.Contains("@") || (!email.Contains(".com") && !email.Contains(".br")))
            {
                Console.Clear();
                terminal.MensagemErro();
                Console.WriteLine("Digite o email do aluno");
                email = Console.ReadLine();
            }
            return email;
        }
        public string Curso(string curso)
        {
            while (curso.Length == 0)
            {
                Console.Clear();
                terminal.MensagemErro();
                Console.WriteLine("Digite o curso do aluno");
                curso = Console.ReadLine();
            }
            return curso;
        }

    }
}

