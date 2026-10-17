namespace MiniBanco.ConsoleApp;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("\n\t\t\t\t=========================================================");
    Console.WriteLine("\t\t\t\t|\tMINIBANCO .NET - MOTOR DE GESTÃO DE CONTAS\t|");
    Console.WriteLine("\t\t\t\t=========================================================\n");

    // List<Conta> contas = new List<Conta>();
    int opcao = -1;

    while (opcao != 0)
    {
      // MostrarMenu();

      Console.Write("\n1- Abrir Nova Conta\t  ");
      Console.Write("2- Registrar Movimentação\t");
      Console.Write("3- Aplicar Fechamento Mensal\t");
      Console.Write("4- Exibir Relatório  das Contas\t");
      Console.WriteLine("0- Sair\t\n");
      Console.Write("Escolha uma opção: ");
      if (int.TryParse(Console.ReadLine(), out opcao))
      {
        switch (opcao)
        {
          case 1: Console.WriteLine("Abrir Nova Conta"); break;
          case 2: Console.WriteLine("Registrar Movimentação"); break;
          case 3: Console.WriteLine("Aplicar Fechamento Mensal"); break;
          case 4: Console.WriteLine("Exibir Relatório  das Contas"); break;
          case 0: Console.WriteLine("Saindo...\n"); break;
          default: Console.WriteLine("Opção inválida!\nDigite um número válido."); break;
        }
      }
      else
      {
        opcao = -1; // Reset opcao to continue the loop
        Console.WriteLine("Opção inválida!\nDigite um número válido.");
      }
    }
  }
}
