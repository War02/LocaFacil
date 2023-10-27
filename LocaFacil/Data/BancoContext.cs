using LocaFacil.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LocaFacil.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) :
    base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<CarroModel> Carros { get; set; }

    }
}
  