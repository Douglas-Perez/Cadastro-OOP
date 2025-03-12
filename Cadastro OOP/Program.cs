namespace Cadastro_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terminal terminal = new();
            Verificar verificar = new();
            int matricula = 0;
            List<Aluno> alunos = new();
                Console.WriteLine("Bem vindo ao nosso sistema de cadastro!");
            while (true)
            {
                Console.WriteLine("O que gostaria de fazer?\n");
                switch (terminal.Menu())
                {
                    case 1: //lista
                        if (alunos.Count == 0)
                        {
                            Console.WriteLine("Nenhum aluno cadastrado.");
                        }
                        if (alunos.Count > 0)
                        {
                            foreach (Aluno aluno in alunos)
                            {
                                aluno.Informacoes();
                            }
                        }
                        terminal.Espera();
                        break;
                    case 2: //cadastrar
                        Console.WriteLine("Digite o nome do aluno");
                        string nome = verificar.Nome(Console.ReadLine());

                        Console.WriteLine("Digite o E-mail do aluno");
                        string email = verificar.Email(Console.ReadLine());
                        
                        Console.WriteLine("Digite o Curso do aluno");
                        string curso = verificar.Curso(Console.ReadLine());
                        
                        matricula++;
                        alunos.Add(new Aluno(nome,email,curso,matricula));
                        terminal.Espera();
                        break;
                    case 3: //sair
                        Console.WriteLine("Obrigado por usar nosso sistema!");
                        terminal.Espera();
                        return;
                }
            }
        }
    }
}
