using System;

namespace EfNinject.Entities
{
    /// <summary>
    /// Persona
    /// </summary>
    public class Persona
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Fecha de nacimiento
        /// </summary>
        public DateTime BirthDate { get; set; }
    }
}