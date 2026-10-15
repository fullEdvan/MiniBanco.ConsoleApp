Console.WriteLine("\n\t\t=========================================");
Console.WriteLine("\t\t|\tBem-vindo ao MiniBanco!\t\t|");
Console.WriteLine("\t\t=========================================\n");

// List<Conta> contas = new List<Conta>();
int opcao = -1;

while (opcao != 0)
{
  // MostrarMenu();

  Console.Write("\n1- Abrir Conta\t  ");
  Console.Write("2- Movimentar Conta\t");
  Console.Write("3- Fechar Mês\t");
  Console.Write("4- Relatório\t");
  Console.WriteLine("0- Sair\t\n");
  Console.Write("Escolha uma opção: ");
  if (int.TryParse(Console.ReadLine(), out opcao))
  {
    switch (opcao)
    {
      case 1: Console.WriteLine("Abrir Conta"); break;
      case 2: Console.WriteLine("Movimentar Conta"); break;
      case 3: Console.WriteLine("Fechar Mês"); break;
      case 4: Console.WriteLine("Relatório"); break;
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