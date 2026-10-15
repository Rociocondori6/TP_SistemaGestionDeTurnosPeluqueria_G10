using System;
using System.Collections.Generic;
using System.Text;

namespace PeluCore.Models
{
    public class Turno
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public string Estado { get; set; }

        // claves foraneas

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int EstilistaId { get; set; }
        public Estilista Estilista { get; set; }

        public int ServicioId { get; set; }
        public Servicio Servicio { get; set; }

        public int? PromocionId { get; set; }
        public Promocion Promocion { get; set; }
    }
}
