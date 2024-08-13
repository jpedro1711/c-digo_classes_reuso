using BibliotecaAPI.Models.Enums;

namespace BibliotecaAPI.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public StatusReserva StatusReserva { get; set; }
        public DateTime DataReserva = DateTime.Now;
        public List<Livro> Livros { get; set; } = new List<Livro> { };
    }
}
