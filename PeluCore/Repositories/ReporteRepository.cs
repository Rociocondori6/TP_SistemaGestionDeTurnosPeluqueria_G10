using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PeluCore.Data;
using PeluCore.Models;


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
        public List<object> ObtenerTurnosPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            
            return _context.Turnos
                .Include(t => t.Cliente)
                .Include(t => t.Servicio)
                .Include(t => t.Estilista)
                .Where(t => t.FechaHora.Date >= fechaDesde.Date && t.FechaHora.Date <= fechaHasta.Date)
                .Select(t => new
                {
                    t.Id,
                    Fecha = t.FechaHora.ToString("dd/MM/yyyy HH:mm"),
                    ClienteNombre = t.Cliente.Nombre + " " + t.Cliente.Apellido,
                    ServicioNombre = t.Servicio.Nombre,
                    EstilistaNombre = t.Estilista.Nombre + " " + t.Estilista.Apellido,
                    t.Estado
                }).Cast<object>().ToList();

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
                    CantidadTurnos = g.Count(),
                })
                .OrderByDescending(x => x.CantidadTurnos)
                .Cast<object>()
                .ToList();
        }

        // 3. reporte de servicios mas demandados 
        public List<object> ObtenerServiciosMasDemandados(DateTime fechaDesde, DateTime fechaHasta)
        {
            return _context.Turnos
                .Include(t => t.Servicio)
                .Where(t => t.FechaHora.Date >= fechaDesde.Date && t.FechaHora.Date <= fechaHasta.Date)
                .GroupBy(t => t.Servicio.Nombre)
                .Select(g => new
                {
                    ServicioNombre = g.Key,
                    VecesSolicitado = g.Count(),
                })
                .OrderByDescending(x => x.VecesSolicitado)
                .Cast<object>()
                .ToList();
        }

        // 4. reporte de historial de clientes

        public List<object> ObtenerHistorialClientes(DateTime fechaDesde, DateTime fechaHasta)
        {
            return _context.Turnos
                .Include(t => t.Cliente)
                .Where(t => t.FechaHora.Date >= fechaDesde.Date && t.FechaHora.Date <= fechaHasta.Date)
                .GroupBy(t => new { t.Cliente.Id, t.Cliente.Nombre, t.Cliente.Apellido })
                .Select(g => new
                {
                    ClienteNombre = g.Key.Nombre + " " + g.Key.Apellido,
                    TotalVisitas = g.Count(),
                    UltimoVisita = g.Max(t => t.FechaHora).ToString("dd/MM/yyyy HH:mm"),
                    EstadoFidelidad = g.Count() >= 5 ? "Califica para beneficios" : "Cliente Ocasional"
                })
                .OrderByDescending(x => x.TotalVisitas)
                .Cast<object>()
                .ToList();

        }

        // 5. reporte de clientes frecuentes
        public List<object> ObtenerClientesFrecuentes(int umbral = 5)
        {
            return _context.Turnos
                .Include(t => t.Cliente)
                .GroupBy(t => t.Cliente)
                .Select(g => new
                {
                    Cliente = g.Key.Nombre + " " + g.Key.Apellido,
                    TotalTurnos = g.Count(),
                    Beneficio = "Apto para descuento"
                })
                .Where(x => x.TotalTurnos >= umbral)
                .OrderByDescending(x => x.TotalTurnos)
                .Cast<object>()
                .ToList();
        }
    }
}
