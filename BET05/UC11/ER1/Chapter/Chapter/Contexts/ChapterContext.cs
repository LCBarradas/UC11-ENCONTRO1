using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class ChapterContext: DbContext
    {
        public ChapterContext()
        {

        }

        public ChapterContext(DbContextOptions<ChapterContext> options): base(options)
        {

        }
        //Vamos utilizar esse metodo para configurar o banco de dados

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                //cada provedor tem sua sintaxe para especificação
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-M021IKH\\SQLEXPRESS; initial catalog = Chapter Integrate Security = true");
            }
        }
        //dbset representa as entidades que serão utilizadas nas operaçoes de leitura, criacao, atualizacao e delecao
        public DbSet<Livro>Livros { get; set; }
    }
}
