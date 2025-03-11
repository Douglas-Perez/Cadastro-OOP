namespace Cadastro_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terminal terminal = new();
            int matricula = 0;
            List<Aluno> alunos = new();
                Console.WriteLine("Bem vindo ao nosso sistema de cadastro!\nO que gostaria de fazer?\n");
            while (true)
            {
                switch (terminal.Menu())
                {
                    case 1: //lista
                        break;
                    case 2: //cadastrar
                        Console.WriteLine("Digite o nome do aluno");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o E-mail do aluno");
                        string email = Console.ReadLine();
                        Console.WriteLine("Digite o Curso do aluno");
                        string curso = Console.ReadLine();
                        matricula++;
                        alunos.Add(new Aluno(nome,email,curso,matricula));
                        break;
                    case 3: //sair
                        return;
                }
            }
        }
    }
}
