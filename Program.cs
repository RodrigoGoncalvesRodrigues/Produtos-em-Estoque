Estoque baitaca = new Estoque();
Console.WriteLine("Informe o nome do produto para adicionar:");
baitaca.produto = Console.ReadLine();
Console.WriteLine("Informe a quantidade de produtos em estoque:");
int quantidade = Convert.ToInt32(Console.ReadLine());
baitaca.adicionarEstoque(quantidade);
Console.WriteLine("Informe o valor do produto:");
baitaca.preco = Convert.ToDouble(Console.ReadLine());
baitaca.exibeInformacoes();