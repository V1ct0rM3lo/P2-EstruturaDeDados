
public class Program
{
    public static void Main(string[] args)
    {
        // Teste da struct Funcionario
        Funcionario funcionario = new Funcionario();
        funcionario.nome = "João";
        funcionario.cargo = "Analista";
        funcionario.salario = 5000.00f;
        funcionario.cargaHoraria = 40;

        funcionario.imprimir();

        funcionario.promover("Gerente", 2000.00f);
        funcionario.imprimir();

        funcionario.aumentarCargaHorariaDeTrabalho(10);
        funcionario.imprimir();

        funcionario.descontoSalarialPorFaltaEmValor(100.00f);
        funcionario.imprimir();

        // Teste da lista encadeada de carros
        ListaCarros listaCarros = new ListaCarros();
        listaCarros.InserirCarro("Modelo A", "Montadora X", DateTime.Now, 50000.00m);
        listaCarros.InserirCarro("Modelo B", "Montadora Y", DateTime.Now, 60000.00m);
        listaCarros.InserirCarro("Modelo C", "Montadora Z", DateTime.Now, 70000.00m);

        listaCarros.PercorrerCarros();

        bool carroEncontrado = listaCarros.ConsultarCarroPorNome("Modelo B");
        if (carroEncontrado)
        {
            Console.WriteLine("O carro foi encontrado na lista.");
        }
        else
        {
            Console.WriteLine("O carro não foi encontrado na lista.");
        }

        listaCarros.RemoverUltimoCarro();
        listaCarros.PercorrerCarros();
    }
}
