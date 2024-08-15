using BibliotecaAPI.Models.Enums;

namespace BibliotecaAPI.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public Reserva Reserva { get; set; }
        public DateTime DataDevolucao  { get; set; }
        public StatusEmprestimo StatusEmprestimo { get; set; }
    }
}
