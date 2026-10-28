using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PeluCore.Data;

namespace PeluCore.Repositories
{
    public class TurnoRepository
    {
        private readonly AplicationDbContext _context;
        public TurnoRepository()
        {
            _context = new AplicationDbContext();
        }
        public List<Object> ObtenerTurnosParaGrilla()
        {
            return _context.Turnos
                .Include(t => t.Cliente)
                .Include(t => t.Servicio)
                .Include(t => t.Estilista)
                
                .Select(t => new
                {
                    Fecha = t.FechaHora.ToString("dd/MM/yyyy HH:mm"),
                    ClienteNombre = t.Cliente.Nombre + " " + t.Cliente.Apellido,
                    ServicioNombre = t.Servicio.Nombre,
                    EstilistaNombre = t.Estilista.Nombre + " " + t.Estilista.Apellido,
                    

                })
                .Cast<object>()   
                .ToList();
        }
    }
}
