using BibliotecaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<GeneroLivro> Generos { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=Biblioteca;User=root;Password=password;");
        }
    }
}
