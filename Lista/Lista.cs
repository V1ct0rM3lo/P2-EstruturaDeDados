
// Definição da classe ListaCarros
public class ListaCarros
{
    private NoCarro primeiro;
    private NoCarro ultimo;

    public void InserirCarro(string nomeModelo, string fabricanteMontadora, DateTime dataFabricacao, decimal preco)
    {
        NoCarro novoCarro = new NoCarro();
        novoCarro.nomeModelo = nomeModelo;
        novoCarro.fabricanteMontadora = fabricanteMontadora;
        novoCarro.dataFabricacao = dataFabricacao;
        novoCarro.preco = preco;

        if (primeiro == null)
        {
            primeiro = novoCarro;
            ultimo = novoCarro;
        }
        else
        {
            ultimo.proximo = novoCarro;
            ultimo = novoCarro;
        }
    }

    public bool ConsultarCarroPorNome(string nomeModelo)
    {
        NoCarro atual = primeiro;

        while (atual != null)
        {
            if (atual.nomeModelo.Equals(nomeModelo))
            {
                return true;
            }

            atual = atual.proximo;
        }

        return false;
    }

    public void RemoverUltimoCarro()
    {
        if (primeiro == null)
        {
            Console.WriteLine("A lista de carros está vazia.");
            return;
        }

        if (primeiro == ultimo)
        {
            primeiro = null;
            ultimo = null;
            return;
        }

        NoCarro atual = primeiro;
        while (atual.proximo != ultimo)
        {
            atual = atual.proximo;
        }

        atual.proximo = null;
        ultimo = atual;
    }

    public void PercorrerCarros()
    {
        NoCarro atual = primeiro;

        while (atual != null)
        {
            Console.WriteLine("Nome do Modelo: " + atual.nomeModelo);
            Console.WriteLine("Fabricante/Montadora: " + atual.fabricanteMontadora);
            Console.WriteLine("Data de Fabricação: " + atual.dataFabricacao);
            Console.WriteLine("Preço: " + atual.preco);
            Console.WriteLine();

            atual = atual.proximo;
        }
    }
}
