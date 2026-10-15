using System;
using System.Collections.Generic;
using System.Text;

namespace PeluCore.Models
{
    public class Promocion
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Descuento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Activa { get; set; }

        public ICollection<Turno> Turnos { get; set; }
    }
}
