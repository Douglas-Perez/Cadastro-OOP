using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_OOP
{
    class Terminal
    {
        public void MensagemErro()
        {
            Console.WriteLine("Erro! valor inválido, tente novamente.\n");
        }

        public int Menu()
        {
            bool teste;
            int resposta;
            do
            {
                Console.WriteLine("1 -> Visualizar lista de alunos\n2 -> Cadastrar aluno novo\n3 -> sair\n");
                Console.Clear();
                teste = int.TryParse(Console.ReadLine(), out resposta);
                if (!teste || resposta < 1 || resposta > 3)
                {
                    MensagemErro();
                }
            } while (!teste || resposta < 1 || resposta > 3);
            return resposta;
        }

        public void Espera()
        {
            Console.WriteLine("\nPreciosse 'Enter' para continuar");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
