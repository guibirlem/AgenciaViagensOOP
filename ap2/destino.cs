public class Destino
{
    public string NomeLocal { get; set; }
    public string Pais { get; set; }
    public string Codigo { get; set; }
    public string Descricao { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Destino: {NomeLocal}, País: {Pais}, Descrição: {Descricao}");
    }
}
