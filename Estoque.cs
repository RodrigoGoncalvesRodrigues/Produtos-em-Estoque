class Estoque 
{
    public string produto; 
    public int quantidade;
    public double preco;
    public void adicionarEstoque(int adicionar )
    {
        quantidade = quantidade + adicionar;
    }

    // public void removerEstoque(int Remover){
    //     quantidade -= quantidade;
    // }
    public void removerEstoque(int quantidade){
        this.quantidade -= quantidade;
    }

    public double valorTotal(){
        return quantidade * preco;
    }

    public void exibeInformacoes()
    {
        Console.WriteLine($"nome do produto: {produto}");
        Console.WriteLine($"Quantidade produto: {quantidade}");
        Console.WriteLine($"Valor do produto: {preco}");
        Console.WriteLine($"nome do produto: {valorTotal()}");
    }


}

