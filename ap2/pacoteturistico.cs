public class PacoteTuristico : ServicoViagem
{
    public Destino Destino { get; set; }
    public string Datas { get; set; } 
    public decimal Preco { get; set; }
    public int VagasDisponiveis { get; set; }

    public override void Reservar()
    {
        if (VagasDisponiveis > 0)
        {
            VagasDisponiveis--;
            Console.WriteLine($"Reserva confirmada para o destino: {Destino.NomeLocal}");
        }
        else
        {
            Console.WriteLine("Sem vagas disponíveis.");
        }
    }

    public override void Cancelar()
    {
        VagasDisponiveis++;
        Console.WriteLine($"Reserva cancelada para o destino: {Destino.NomeLocal}");
    }
}
