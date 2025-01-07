using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using API_CRUD.Models;

namespace API_CRUD.Data
{
    public class ClassConexion : DbContext
    {
        public ClassConexion(DbContextOptions<ClassConexion> options)
                    : base(options)
        {
        }

        // DbSet que representa la tabla de semestre en la base de datos
        public DbSet<SemestreModel> Semestre { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Si la propiedad de clave primaria no se llama "Id", puedes configurar explícitamente la clave
            modelBuilder.Entity<SemestreModel>()
                .HasKey(s => s.Id_Semestre);  // Asegúrate de que 'Id' es la propiedad de clave primaria
        }
    }
}
