// See https://aka.ms/new-console-template for more information
var lista_clientes = new List<Clientes>();
var lista_artistas = new List<Artistas>();
var lista_discos = new List<Discos>();
var lista_formatos = new List<Formatos>();
var lista_pagos = new List<Pagos>();
var lista_ordenes = new List<Ordenes>();
var lista_inventarios = new List<Inventarios>();
var lista_ordenes_discos = new List<OrdenesDiscos>();
var lista_inventarios_formatos = new List<InventariosFormatos>();

lista_clientes.Add(new Clientes()
{
    IdCliente = "C001",
    NombreCliente = "Juan",
    ApellidoCliente = "Perez",
    DireccionCliente = "Calle 12",
    TelefonoCliente = "304258299"
});
lista_clientes.Add(new Clientes()
{
    IdCliente = "C002",
    NombreCliente = "Maria",
    ApellidoCliente = "Cardona",
    DireccionCliente = "Calle 12",
    TelefonoCliente = "304258299"
});
lista_clientes.Add(new Clientes()
{
    IdCliente = "C003",
    NombreCliente = "Carlos",
    ApellidoCliente = "Gomez",
    DireccionCliente = "Calle 12",
    TelefonoCliente = "304258299"
});
lista_artistas.Add(new Artistas()
{
    IdArtista = "A001",
    NombreArtista = "The Doors",
    GeneroMusical = "Rock"
});
lista_artistas.Add(new Artistas()
{
    IdArtista = "A002",
    NombreArtista = "Frank Sinatra",
    GeneroMusical = "Jazz"
});
lista_artistas.Add(new Artistas()
{
    IdArtista = "A003",
    NombreArtista = "Ariana Grande",
    GeneroMusical = "Pop"
});
lista_artistas.Add(new Artistas()
{
    IdArtista = "A004",
    NombreArtista = "Kanye West",
    GeneroMusical = "Rap"
});
lista_discos.Add(new Discos()
{
    IdDisco = "D001",
    Artista = "A001",
    NombreDisco = "Love Street",
    FechaLanzamiento = new DateTime(1968, 7, 2),
    Descripcion = "Escrita por Jim",
    _Artista = new Artistas { IdArtista = "A001", NombreArtista = "The Doors", GeneroMusical = "Rock" }
});
lista_discos.Add(new Discos()
{
    IdDisco = "D002",
    Artista = "A002",
    NombreDisco = "My Way",
    FechaLanzamiento = new DateTime(1969, 8, 10),
    Descripcion = "Inspirada en una pelicula",
    _Artista = new Artistas { IdArtista = "A002", NombreArtista = "Frank Sinatra", GeneroMusical = "Jazz" }
});
lista_discos.Add(new Discos()
{
    IdDisco = "D003",
    Artista = "A003",
    NombreDisco = "7 Rings",
    FechaLanzamiento = new DateTime(2019, 1, 18),
    Descripcion = "Inspirada en el empoderamiento, riqueza y amistad.",
    _Artista = new Artistas { IdArtista = "A003", NombreArtista = "Ariana Grande", GeneroMusical = "Pop" }
});
lista_discos.Add(new Discos()
{
    IdDisco = "D004",
    Artista = "A004",
    NombreDisco = "I Wonder",
    FechaLanzamiento = new DateTime(1967, 5, 3),
    Descripcion = "Inspirada en la búsqueda de los sueños y la ambición",
    _Artista = new Artistas { IdArtista = "A004", NombreArtista = "Kanye West", GeneroMusical = "Rap" }
});
lista_formatos.Add(new Formatos()
{
    IdFormato = "F001",
    TipoFormato = "Vinilo",
    Material = "Aluminio"
});
lista_formatos.Add(new Formatos()
{
    IdFormato = "F002",
    TipoFormato = "CD",
    Material = "Plastico"
});
lista_pagos.Add(new Pagos()
{
    IdPago = "P001",
    TipoPago = "Transferencia",
    //Falta atributo
});
lista_pagos.Add(new Pagos()
{
    IdPago = "P002",
    TipoPago = "Contra entrega",
    //Falta atributo
});
lista_ordenes.Add(new Ordenes(){
IdOrdenes = "AAAA",
Fecha = new DateTime(2024,12,10),
Cliente = "C001",
Pago = "P001",
MontoTotal = 150,
_Cliente = lista_clientes[0],
_Pago = lista_pagos[0]
});
lista_ordenes.Add(new Ordenes(){
IdOrdenes = "BBBB",
Fecha = new DateTime(2024,12,10),
Cliente = "C002",
Pago = "P002",
MontoTotal = 150,
_Cliente = lista_clientes[1],
_Pago = lista_pagos[1]
});
lista_ordenes.Add(new Ordenes(){
IdOrdenes = "CCCC",
Fecha = new DateTime(2024,12,10),
Cliente = "C003",
Pago = "P001",
MontoTotal = 150,
_Cliente = lista_clientes[2],
_Pago = lista_pagos[0]
});

Console.WriteLine(lista_clientes.Count);
public class Clientes
{
    public string? IdCliente { get; set; }
    public string? NombreCliente { get; set; }
    public string? ApellidoCliente { get; set; }
    public string? DireccionCliente { get; set; }
    public string? TelefonoCliente { get; set; }
    public List<Ordenes>? Ordenes { get; set; } //Relacion 1:M con ordenes

}
public class Artistas
{
    public string? IdArtista { get; set; }
    public string? NombreArtista { get; set; }
    public string? GeneroMusical { get; set; }
    public List<Discos>? Discos { get; set; }//Relacion 1:M con Discos

}
public class Discos
{
    public string? IdDisco { get; set; }
    public string? Artista { get; set; } //Id del artista clave foranea
    public string? NombreDisco { get; set; }
    public DateTime FechaLanzamiento { get; set; }
    public string? Descripcion { get; set; }
    public Artistas? _Artista { get; set; } // Propiedad de navegación para acceder a los datos del artista
    public List<OrdenesDiscos>? OrdenesDiscos { get; set; } //Relacion 1:M con ordenes_discos

}
public class Formatos
{
    public string? IdFormato { get; set; }
    public string? TipoFormato { get; set; }
    public string? Material { get; set; }
    public List<OrdenesDiscos>? OrdenesDiscos { get; set; }

}
public class Pagos
{
    public string? IdPago { get; set; }
    public string? TipoPago { get; set; }
    //Falta atributo

}
public class Ordenes
{
    public string? IdOrdenes { get; set; }
    public DateTime Fecha { get; set; }
    public string? Cliente { get; set; } //Id del cliente clave foranea
    public string? Pago { get; set; } //Id del pago clave foranea
    public double MontoTotal { get; set; }
    public Clientes? _Cliente { get; set; } // Propiedad de navegación para acceder a los datos del cliente
    public Pagos? _Pago { get; set; } // Propiedad de navegación para acceder a los datos del pago
    public List<OrdenesDiscos>? OrdenesDiscos { get; set; }

}
public class Inventarios
{
    public int IdInventario { get; set; }
    public int Disco { get; set; } //Id del disco clave foranea 
    public string? Ubicacion { get; set; }
    public int StockTotal { get; set; }
    public Discos? _Discos { get; set; } //Relacion con discos
}
public class OrdenesDiscos
{
    public int IdOrdenesDiscos { get; set; }
    public int Orden { get; set; } //Id de la orden clave foranea
    public int Disco { get; set; } //Id del disco clave foranea
    public int Formato { get; set; } //Id del formato clave foranea
    public int Cantidad { get; set; }
    public double ValorUnitario { get; set; }
    public Ordenes? _Ordenes { get; set; } // Propiedad de navegación para acceder a los datos de las ordenes
    public Discos? _Disco { get; set; } // Propiedad de navegación para acceder a los datos del disco
    public Formatos? _Formato { get; set; } // Propiedad de navegación para acceder a los datos del formato

}

public class InventariosFormatos
{
    public int IdInventarioFormato { get; set; }
    public int Inventario { get; set; } //Id del inventario clave foranea 
    public int Formato { get; set; } //Id del formato clave foranea
    public int StockTotal { get; set; }
    public Inventarios? _Inventarios { get; set; } //Relacion con inventarios
    public Formatos? _Formatos { get; set; } //Relacion con formatos

}
