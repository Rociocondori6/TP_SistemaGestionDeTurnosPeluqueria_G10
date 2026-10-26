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
        public List<object> ObtenerTurnosPorRangos(DateTime fechaDesde, DateTime fechaHasta)
        {
            return _context.Turnos
                .Include(t => t.Cliente)
                .Include(t => t.Servicio)
                .Include(t => t.Estilista)
                .Where(t => t.FechaHora.Date >= fechaDesde.Date && t.FechaHora.Date <= fechaHasta.Date)
                .Select(t => new
                {
                    Fecha = t.FechaHora.ToShortDateString(),
                    Hora = t.FechaHora.ToShortTimeString(),
                    ClienteNombre = t.Cliente.Nombre + " " + t.Cliente.Apellido,
                    ServicioNombre = t.Servicio.Nombre,
                    EstilistaNombre = t.Estilista.Nombre + " " + t.Estilista.Apellido
                })
                .Cast<object>()
                .ToList();
        }

        // 2. reporte de rendimiento por estilista
        public List<object> ObtenerRendimientoPorEstilista(DateTime fechaDesde, DateTime fechaHasta)
        {
            return _context.Turnos
                .Include(t => t.Estilista)
                .Where(t => t.FechaHora.Date >= fechaDesde.Date && t.FechaHora.Date <= fechaHasta.Date)
                .GroupBy(t => new { t.Estilista.Id, t.Estilista.Nombre, t.Estilista.Apellido })
                .Select(g => new
                {
                    EstilistaNombre = g.Key.Nombre + " " + g.Key.Apellido,
                    CantidadTurnos = g.Count()
                })
                .Cast<object>()
                .ToList();
        }

        // 3. reporte de servicios mas demandados 
        public List<object> ObtenerServiciosMasDemandados(DateTime fechaDesde, DateTime fechaHasta)
        {
            return _context.Turnos
                .Include(t => t.Servicio)
                .Where(t => t.FechaHora.Date >= fechaDesde.Date && t.FechaHora.Date <= fechaHasta.Date)
                .GroupBy(t => new { t.Servicio.Id, t.Servicio.Nombre })
                .Select(g => new
                {
                    ServicioNombre = g.Key.Nombre,
                    CantidadTurnos = g.Count()
                })
                .OrderByDescending(x => x.CantidadTurnos)
                .Cast<object>()
                .ToList();
        }
    }
}
