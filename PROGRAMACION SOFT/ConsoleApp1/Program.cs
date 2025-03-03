// See https://aka.ms/new-console-template for more information

using System.Data.Common;

var lista_estudiantes = new List<Estudiantes>();
var lista_profesores = new List<Profesores>();

lista_estudiantes.Add(new Estudiantes()
{
    Id = 1,
    Carnet = "101",
    Nombre = "Sofia"
});
lista_estudiantes.Add(new Estudiantes()
{
    Id = 2,
    Carnet = "102",
    Nombre = "Pedro"
});
lista_estudiantes.Add(new Estudiantes()
{
    Id = 3,
    Carnet = "103",
    Nombre = "Marcela"
});
lista_profesores.Add(new Profesores()
{
    Id = 1,
    Codigo = "1020",
    Nombre = "Juan"
});
lista_profesores.Add(new Profesores()
{
    Id = 2,
    Codigo = "1021",
    Nombre = "Carlos"
});
lista_profesores.Add(new Profesores()
{
    Id = 3,
    Codigo = "1022",
    Nombre = "Ana"
});
lista_profesores.Add(new Profesores()
{
    Id = 4,
    Codigo = "1023",
    Nombre = "Rodolfo"
});
var lista_profesores_estudiantes = new List<Profesores_Estudiantes>();
lista_profesores_estudiantes.Add(new Profesores_Estudiantes()
{
    Id = 1,
    Profesor = 1,
    Estudiante = 1,
    _Profesor = new Profesores() { Id = 1, Codigo = "1020", Nombre = "Juan" },
    _Estudiante = new Estudiantes() { Id = 1, Carnet = "101", Nombre = "Sofia" }
});
lista_profesores_estudiantes.Add(new Profesores_Estudiantes()
{
    Id = 2,
    Profesor = 1,
    Estudiante = 2,
    _Profesor = lista_profesores[0],
    _Estudiante = lista_estudiantes[1]
});
Console.WriteLine(lista_estudiantes.Count);
Console.WriteLine(lista_profesores.Count);
Console.WriteLine(lista_profesores_estudiantes.Count);
public class Estudiantes
{
    public int Id { get; set; }
    public string? Carnet { get; set; }
    public string? Nombre { get; set; }
    public DateTime Fecha { get; set; }
    public string? Carrera { get; set; }
    public List<Profesores_Estudiantes>? Profesores_Estudiantes { get; set; }

}
public class Profesores
{
    public int Id { get; set; }
    public string? Codigo { get; set; }
    public string? Correo { get; set; }
    public string? Nombre { get; set; }
    public string? CodigoContrato { get; set; }
    public List<Profesores_Estudiantes>? Profesores_Estudiantes { get; set; }

}
public class Profesores_Estudiantes
{
    public int Id { get; set; }
    public int Profesor { get; set; }
    public int Estudiante { get; set; }
    public Profesores? _Profesor { get; set; }
    public Estudiantes? _Estudiante { get; set; }

}
