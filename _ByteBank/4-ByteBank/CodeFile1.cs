public class ContaCorrente
{
    public string nome;
    public int numeroConta;
    public int agencia;
    public double saldo;
    public bool indativo;

    public bool Sacar(double valor)
    {
        if (this.saldo > valor)
        {
            this.saldo -= valor;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if(this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }

}