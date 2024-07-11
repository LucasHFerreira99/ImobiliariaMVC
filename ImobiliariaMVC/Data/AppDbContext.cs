using ImobiliariaMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ImobiliariaMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Locador> Locadores { get; set; }
        public DbSet<Locatario> Locatarios { get; set; }
        public DbSet<Aluguel> Alugueis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Locador>().HasData(
                new Locador { Id = 1, Nome = "Joao Carlos", Endereco = "Rua Japão, 312", Cpf = "123.345.231-12", Identidade = "MG12312312", Atividade = "Comerciante", Telefone = "38313555" },
                new Locador { Id = 2, Nome = "Marcos Castro", Endereco = "Rua Adolfo Pierucetii, 655", Cpf = "654.655.211-12", Identidade = "MG8923712", Atividade = "Padeiro", Telefone = "988745454" }
                );

            modelBuilder.Entity<Imovel>().HasData(
                new Imovel { Id = 1, Endereco = "Rua da Esperança, 777", Valor = 770.00, DonoID = 2, Alugado = false },
                new Imovel { Id = 2, Endereco = "Rua das Palmeiras", Valor = 2000.00, DonoID = 2, Alugado = false },
                new Imovel { Id = 3, Endereco = "Rua das Jacarandas", Valor = 1500.00, DonoID = 1, Alugado = false },
                new Imovel { Id = 4, Endereco = "Rua dos Ipes, 249", Valor = 850.00, DonoID = 1, Alugado = false }
                );
            modelBuilder.Entity<Locatario>().HasData(
                new Locatario { Id = 1, Nome = "Juca Tadeu", Cpf = "654.233.211-12", Identidade = "MG4444442", Atividade = "Mestre de Obra", Telefone = "988774455" },
                new Locatario { Id = 2, Nome = "Confuso Sobrinho", Cpf = "122.233.211-12", Identidade = "MG4324442", Atividade = "Confuso", Telefone = "966335544" },
                new Locatario { Id = 3, Nome = "Chico Moedas", Cpf = "111.233.211-12", Identidade = "MG5555552", Atividade = "Influencer", Telefone = "988552233" }
                );


            base.OnModelCreating(modelBuilder);
        }


    }
}
