using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_OOP
{
    class Verificar
    {
        Terminal terminal = new();
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        public string Nome(string nome)
        {
            while (nome.Length == 0)
            {
                Console.Clear();
                terminal.MensagemErro();
                Console.WriteLine("Digite o nome do aluno");
                nome = Console.ReadLine();
            }
            return textInfo.ToTitleCase(nome.ToLower());
        }
        public string Email(string email)
        {
            while (!email.Contains("@") || (!email.Contains(".com") && !email.Contains(".br") && !email.Contains(".edu")))
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
            return textInfo.ToTitleCase(curso.ToLower());
        }

    }
}

