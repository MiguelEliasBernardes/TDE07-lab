using System.Runtime.CompilerServices;

class Produto
{
    public string nome;
    public int quantidade;
    public double valor;

    public void AdicionarEstoque(int valor)
    {
        if(valor > 0){
            quantidade += valor;
            Console.WriteLine($"A quantidade {valor} foi adicionada ao produto {nome}");
        }else{
            Console.WriteLine("ERRO: Digite um valor válido!");
            Console.ReadKey();
        }
    }

    public void RemoverEstoque(int valor)
    {
        if(valor > 0 && valor <= quantidade){
            quantidade -= valor;
            Console.WriteLine($"A quantidade {valor} foi removida do produto {nome}");
        }else if(valor <= 0){
            Console.WriteLine("O valor informado é menor ou igual a 0");
        }else{
            Console.WriteLine("O valor informado é maior que a quantidade disponível");
        }
    }

    public double CalcularValorEstoque()
    {
        return quantidade * valor;
    }

    public void DefinirValores()
    {
        Console.WriteLine("1 - informe o nome do produto:");
        nome = Console.ReadLine();
        Console.WriteLine("2 - informe a quantidade em estoque:");
        quantidade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("3 - informe o valor do produto:");
        valor = Convert.ToDouble(Console.ReadLine());
    }

    public void ExibirInformações()
    {
        Console.WriteLine("Nome do produto: " + nome);
        Console.WriteLine("Quantidade em estoque do produto: " + quantidade);
        Console.WriteLine("Preço unitario do produto: " + valor);
        Console.WriteLine("Valor total em estoque: " + CalcularValorEstoque());
    }
}