using BibliotecaAPI.Models.Enums;

namespace BibliotecaAPI.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public StatusLivro Status { get; set; }
        public double NotaAvaliacao { get; set; }
        public GeneroLivro Genero { get; set; }
        public List<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}
