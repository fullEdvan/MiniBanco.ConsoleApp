namespace MiniBanco.ConsoleApp;

public abstract class Conta(string titular, int numero, decimal saldoInicial)
{
  public string Titular { get; } = titular;
  public int Numero { get; } = numero;
  public decimal Saldo { get; protected set; } = saldoInicial;
  public List<Transacao> Extrato { get; } = [];

  public void RegistrarTransacao(string descricao, string tipo, decimal valor)
  {
    var transacao = new Transacao(descricao, tipo, valor);
    Extrato.Add(transacao);
  }
  public void Depositar(string titular, int numero, decimal valor)
  {
    RegistrarTransacao("Depósito", "Deposito", valor);
    Saldo += valor;
    Console.WriteLine($"Depósito realizado com sucesso.");
  }
  public virtual void Sacar(decimal valor) { }
  public virtual void AplicarFechamentoMensal() { }
}