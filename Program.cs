using System.Reflection.Emit;

Produto p1 = new Produto();
bool sair = false;

while(!sair){
    Console.WriteLine("Digite uma opção:");
    Console.WriteLine("1 - Definir os dados");
    Console.WriteLine("2 - Adicionar ao estoque");
    Console.WriteLine("3 - Remover do estoque");
    Console.WriteLine("4 - Exibir detalhes do produto");
    Console.WriteLine("5 - Sair");

    string opcao = Console.ReadLine();

    switch(opcao){
        case "1":
            p1.DefinirValores();
            break;
        case "2":
            Console.WriteLine("Digite um valor para adicionar ao estoque");
            int quantidadeAdicionar = Convert.ToInt32(Console.ReadLine());
            p1.AdicionarEstoque(quantidadeAdicionar);
            break;
        case "3":
            Console.WriteLine("Digite a quantidade que deseja remover do estoque");
            int quantidadeRemover = Convert.ToInt32(Console.ReadLine());
            p1.RemoverEstoque(quantidadeRemover);
            break;
        case "4":
            p1.ExibirInformações();
            break;
        case "5":
            Console.WriteLine("Encerrando o sistema");
            break;
    }
}