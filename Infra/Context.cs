using MCVGamer.Models;
using Microsoft.EntityFrameworkCore;

namespace MCVGamer.Infra
{
    public class Context : DbContext
    {
        public Context()
        {
        }
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = NOTE17-S15; Initial Catalog = mvcGamer; User Id = sa; pwd = Senai@134; TrustServerCertificate = true");  //STRING DE CONEXAO COM O BANCO, PRECISA INSTALAR AS EXTENSOES REFERENTE AO BANCO UTILIZADO
            }
        }
        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Equipe> Equipe { get; set; }





    }
}


//data source es o nome do gerenciador do banco ou seja o nome do servidor
//initial catalog sera o nome do banco de dados 
//intagredted security e trustesercer autenticacao pelo windows
//se fosse por sql  seria userid = " seu login"  //  pwd = "senha do usuario"