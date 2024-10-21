class Program
{
    static void Main(string[] args)
    {
        Agencia agencia = new Agencia();

        Destino destino1 = new Destino { NomeLocal = "Paris", Pais = "França", Codigo = "201", Descricao = "Cidade " };
        agencia.CadastrarDestino(destino1);

        Cliente cliente1 = new Cliente { Nome = "Goao silva", NumeroIdentificacao = "123456890", Contato = "goao@hotmail.com" };
        agencia.CadastrarCliente(cliente1);

        PacoteTuristico pacote1 = new PacoteTuristico { Destino = destino1, Datas = "15/12/2024 - 25/12/2024", Preco = 5000.00M, VagasDisponiveis = 10 };
        agencia.Pacotes.Add(pacote1);

        agencia.ListarDestinos();
        agencia.ListarClientes();

        pacote1.Reservar();
        pacote1.Cancelar();
    }
}
