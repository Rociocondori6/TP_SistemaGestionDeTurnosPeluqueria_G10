using System;
using System.Linq;
<<<<<<< HEAD
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PeluCre.Data;
using PeluCre.Models;


namespace PeluCli;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

       
        ServiceCollection services = new ServiceCollection();
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite("Data Source=peluqueria.db;Foreign Keys=True"));

        ServiceProvider serviceProvider = services.BuildServiceProvider();

       
        using IServiceScope scope = serviceProvider.CreateScope();
        ApplicationDbContext context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        context.Database.EnsureCreated();

        bool salir = false;
        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine(" SISTEMA DE GESTION DE TURNOS - PELUQUERIA ");
            Console.WriteLine("=====================================");
            Console.WriteLine("1. Registrar nuevo Cliente");
            Console.WriteLine("2. Listar Clientes");
            Console.WriteLine("3. Registrar nuevo Estilista");
            Console.WriteLine("4. Listar Estilistas");
            Console.WriteLine("5. Registrar nuevo Turno");
            Console.WriteLine("6.Lista de Turnos");
            Console.WriteLine("7. Modificar / Cancelar Turno");
            Console.WriteLine("8. Salir");
            Console.Write("\nSelecciona una opción: ");

            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("--- Registrar nuevo Cliente ---");
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine() ?? string.Empty;

                    Console.Write("Apellido: ");
                    string apellido = Console.ReadLine() ?? string.Empty;

                    Console.Write("Teléfono: ");
                    string telefono = Console.ReadLine() ?? string.Empty;

                    Console.Write("Email: ");
                    string email = Console.ReadLine() ?? string.Empty;

                    var nuevoCliente = new Cliente
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        Telefono = telefono,
                        Email = email
                    };

                    context.Clientes.Add(nuevoCliente);
                    context.SaveChanges();

                    Console.WriteLine("\n¡Cliente registrado con éxito!");
                    Console.WriteLine("Presiona una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("--- Lista de Clientes ---");
                    var clientes = context.Clientes.ToList();
                    foreach (var c in clientes)
                    {
                        Console.WriteLine($"ID: {c.Id} | Nombre: {c.Nombre} {c.Apellido} | Tel: {c.Telefono} | Email: {c.Email}");
                    }
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("--- Registrar nuevo Estilista ---");
                    Console.Write("Nombre :");
                    string nombreEstilista = Console.ReadLine() ?? string.Empty;

                    Console.Write("Apellido :");
                    string apellidoEstilista = Console.ReadLine() ?? string.Empty;

                    Console.Write("Especialidad :");
                    string especialidad = Console.ReadLine() ?? string.Empty;

                    var nuevoEstilista = new Estilista
                    {
                        Nombre = nombreEstilista,
                        Apellido = apellidoEstilista,
                        Especialidad = especialidad
                    };

                    context.Estilistas.Add(nuevoEstilista);
                    context.SaveChanges();

                    Console.WriteLine("\n¡Estilista registrado con éxito!");
                    Console.WriteLine("Presiona una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("--- Lista de Estilistas ---");
                    var estilistas = context.Estilistas.ToList();
                    foreach (var e in estilistas)
                    {
                        Console.WriteLine($"ID: {e.Id} | Nombre: {e.Nombre} {e.Apellido} | Especialidad: {e.Especialidad}");
                    }

                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "5":
                    Console.Clear();
                    Console.WriteLine("--- Registrar nuevo Turno ---");
                    Console.WriteLine("Ingresa el ID del Cliente :");
                    if (int.TryParse(Console.ReadLine(), out int clienteId))
                    {
                        var cliente = context.Clientes.Find(clienteId);
                        if (cliente != null)
                        {
                            Console.WriteLine("Ingresa el ID del Estilista :");
                            if (int.TryParse(Console.ReadLine(), out int estilistaId))
                            {
                                var estilista = context.Estilistas.Find(estilistaId);
                                if (estilista != null)
                                {
                                    Console.Write("Ingresa la fecha y hora del turno (yyyy-MM-dd HH:mm): ");
                                    if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaHora))
                                    {
                                        var nuevoTurno = new Turno
                                        {
                                            ClienteId = clienteId,
                                            EstilistaId = estilistaId,
                                            FechaHora = fechaHora,
                                            Estado = EstadoTurno.Pendiente
                                        };
                                        context.Turnos.Add(nuevoTurno);
                                        context.SaveChanges();
                                        Console.WriteLine("\n¡Turno registrado con éxito!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nFormato de fecha inválido.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nNo se encontró ningún estilista con ese ID.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nID de estilista inválido.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nNo se encontró ningún cliente con ese ID.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nID  de cliente inválido.");
                    }
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "6": 
                    Console.Clear();
                    Console.WriteLine("--- Lista de Turnos ---");
                    var turnos = context.Turnos
                        .Include(t => t.Cliente)
                        .Include(t => t.Estilista)
                        .ToList();

                    if (turnos.Count == 0)
                    {
                        Console.WriteLine("No hay turnos registrados.");
                    }
                    else
                    {
                        foreach (var t in turnos)
                        {
                            Console.WriteLine($"ID Turno: {t.Id} | Cliente: {t.Cliente?.Nombre} {t.Cliente?.Apellido} | Estilista: {t.Estilista?.Nombre} | Fecha: {t.FechaHora} | Estado: {t.Estado}");
                        }
                    }
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "7":
                    Console.Clear();
                    Console.WriteLine("--- Modificar o Cancelar Turno ---");
                    Console.Write("Ingresa el ID del turno a buscar: ");

                    if (int.TryParse(Console.ReadLine(), out int turnoId))
                    {
                        var turno = context.Turnos.Find(turnoId);

                        if (turno != null)
                        {
                            Console.WriteLine($"\nTurno encontrado - Fecha actual: {turno.FechaHora}");
                            Console.WriteLine("1. Cambiar fecha y hora");
                            Console.WriteLine("2. Dar de baja (Cancelar turno)");
                            Console.Write("Selecciona una acción: ");

                            string? subOpcion = Console.ReadLine();

                            if (subOpcion == "1")
                            {
                                Console.Write("Ingresa la nueva fecha y hora (yyyy-MM-dd HH:mm): ");
                                if (DateTime.TryParse(Console.ReadLine(), out DateTime nuevaFecha))
                                {
                                    turno.FechaHora = nuevaFecha;
                                    context.SaveChanges();
                                    Console.WriteLine("\n¡Fecha del turno actualizada correctamente!");
                                }
                                else
                                {
                                    Console.WriteLine("\nFormato de fecha inválido.");
                                }
                            }
                            else if (subOpcion == "2")
                            {
                                turno.Estado = EstadoTurno.Cancelado;
                                context.SaveChanges();
                                Console.WriteLine("\n¡El turno ha sido dado de baja (cancelado) con éxito!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nNo se encontró ningún turno con ese ID.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nID de turno inválido.");
                    }

                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "8":
                    salir = true;
                    break;
=======
using Microsoft.EntityFrameworkCore;
using PeluCore.Models;
using PeluCore.Data;

namespace PeluCli
{
    class Program
    {
        static void Main(string[]  args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            using (var context = new ApplicationDbContext(new DbContextOptionBuilder<ApplicationDbContext>().UseSqlite("Data Source=peluqueria.db").Options))
            {
                context.Database.EnsureCreated();

                bool salir = false;
                while (!salir)
                {
                    Console.Clear();
                    Console.WriteLine("==========================================");
                    Console.WriteLine("SISTEMA DE GESTION DE TURNOS - PELUQUERIA");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("1. Registrar nuevo Cliente ");
                    Console.WriteLine("2. Lista Vlientes");
                    Console.WriteLine("3. Registrar nuevo Estilista");
                    Console.WriteLine("4. Lista Estilistas");
                    Console.WriteLine("5 . Salir ");
                    Console.Write("\nSelecciona una opción:");

                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine(" --- Registrar nuevo Cliente ---");
                            Console.Write("Nombre: ");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Apellido: ");
                            string apellido = Console.ReadLine();
                            Console.WriteLine("Telefono: ");
                            string telefono = Console.ReadLine();
                            Console.WriteLine("Email: ");
                            string email = Console.ReadLine();

                            var nuevoCliente = new Cliente
                            {
                                Nombre = nombre,
                                Apellido = apellido,
                                Telefono = telefono,
                                Email = email
                            };

                            context.Clientes.Add(nuevoCliente);
                            context.SaveChanges();
                            Console.Write
                    }
                    ;


>>>>>>> c86b038eb0ce1a5ab9ac512ea49b1249f6005264
            }
        }
    }
}