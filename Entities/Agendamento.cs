using BarberTip.Contexts;
namespace BarberTip.Entities;
public class Agendamento{
    public Agendamento(DateTime data, DateTime hora, int idCliente)
    {
        Data = data;
        Hora = hora;
        IdCliente = idCliente;
    }
    public int Id { get; set; }  
    public DateTime Data { get; set; }
    public DateTime Hora { get; set; }
    public int IdCliente { get; set; }
    public Cliente Cliente { get; set; } = null!;    
}