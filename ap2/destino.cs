public class Destino : IPesquisavel
{
    public string NomeLocal { get; set; }
    public string Pais { get; set; }
    public string Codigo { get; set; }
    public string Descricao { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Destino: {NomeLocal}, País: {Pais}, Descrição: {Descricao}");
    }

    // IPesquisavel funciona aqui nao esquecer
    public object PesquisarPorCodigo(string codigo)
    {
        if (this.Codigo == codigo)
        {
            return this;
        }
        return null;
    }

    public object PesquisarPorNome(string nome)
    {
        if (this.NomeLocal == nome)
        {
            return this;
        }
        return null;
    }
}
