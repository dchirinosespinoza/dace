
using Microsoft.EntityFrameworkCore;
using Release.Helper.Data.Core;
using Prod.GESTORPLUS.Datos.Modelo;


namespace Prod.GESTORPLUS.Datos.Contexto
{
    public partial class GestorDbContext : DbContext, IDbContext
    {
        private readonly string _connstr;

        public GestorDbContext(string connstr)
        {
            this._connstr = connstr;
        }

        public GestorDbContext(DbContextOptions<GestorDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrWhiteSpace(this._connstr))
            {                
                optionsBuilder.UseSqlServer(this._connstr, b=>b.UseRowNumberForPaging());
            }
        }
        /*Copiado Manualmente desde /MapDB/Prod.ArquetipoNetCore.Datos */
        public virtual DbSet<persona> persona { get; set; }
        public virtual DbSet<institucion> institucion { get; set; }
        public virtual DbSet<sede> sede { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<rol> rol { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
    }
}
