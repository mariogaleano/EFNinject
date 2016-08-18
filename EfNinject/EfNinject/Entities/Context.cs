using System.Data.Entity;

namespace EfNinject.Entities
{
    public class Context : DbContext, IContext
    {
        public Context() : base("name=conexion")
        {
            Database.Log = (c) => System.Diagnostics.Debug.WriteLine(c);            
        }

        public DbSet<Persona> Personas { get; set; }
    }
}
