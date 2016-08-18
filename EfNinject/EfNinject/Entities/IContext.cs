using System.Data.Entity;

namespace EfNinject.Entities
{
    public interface IContext
    {
        DbSet<Persona> Personas { get; set; }
    }
}