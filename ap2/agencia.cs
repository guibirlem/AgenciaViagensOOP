public class Agencia
{
    public List<Destino> Destinos { get; set; } = new List<Destino>();
    public List<Cliente> Clientes { get; set; } = new List<Cliente>();
    public List<PacoteTuristico> Pacotes { get; set; } = new List<PacoteTuristico>();

    public void CadastrarDestino(Destino destino)
    {
        Destinos.Add(destino);
        Console.WriteLine("Destino cadastrado!");
    }

    public void ListarDestinos()
    {
        foreach (var destino in Destinos)
        {
            destino.ExibirInformacoes();
        }
    }

    public void CadastrarCliente(Cliente cliente)
    {
        Clientes.Add(cliente);
        Console.WriteLine("Cliente cadastrado!");
    }

    public void ListarClientes()
    {
        foreach (var cliente in Clientes)
        {
            cliente.ExibirInformacoes();
        }
    }

    public object PesquisarDestinoPorCodigo(string codigo)
    {
        foreach (var destino in Destinos)
        {
            var resultado = destino.PesquisarPorCodigo(codigo);
            if (resultado != null) return resultado;
        }
        return null;
    }

    public object PesquisarPacotePorNome(string nome)
    {
        foreach (var pacote in Pacotes)
        {
            var resultado = pacote.PesquisarPorNome(nome);
            if (resultado != null) return resultado;
        }
        return null;
    }
}
