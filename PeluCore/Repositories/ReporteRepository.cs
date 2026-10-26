using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PeluCore.Data;


namespace PeluCore.Repositories
{
    public class ReporteRepository
    {
        private readonly AplicationDbContext _context;

        public ReporteRepository()
        {
            _context = new AplicationDbContext();
        }

        // 1. reporte de turnos diarios (agenda)
        public List<object> ObtenerTurnosDiarios(DateTime fechaBuscada)
        {
            return _context.Turnos
                .Include(t => t.Cliente)
                .Include(t => t.Servicio)
                .Include(t => t.Estilista)
                .Where(t => t.FechaHora.Date == fechaBuscada.Date)
                .Select(t => new
                {
                    Hora = t.FechaHora.ToShortTimeString(),
                    ClienteNombre = t.Cliente.Nombre + " " + t.Cliente.Apellido,
                    ServicioNombre = t.Servicio.Nombre,
                    EstilistaNombre = t.Estilista.Nombre + " " + t.Estilista.Apellido
                })
                .Cast<object>()
                .ToList();
        }

    }
}
