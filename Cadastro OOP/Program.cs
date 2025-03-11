namespace Cadastro_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terminal terminal = new();
            while (true)
            {
                Console.WriteLine("Bem vindo ao nosso sistema de cadastro!\nO que gostaria de fazer?\n");
                switch (terminal.Menu())
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        return;
                }
            }
        }
    }
}
