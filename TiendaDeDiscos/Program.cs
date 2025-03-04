// See https://aka.ms/new-console-template for more information
Console.WriteLine("Holaaaa");

var lista_clientes = new List<Clientes>();
var lista_artistas = new List<Artistas>();
var lista_discos = new List<Discos>();
var lista_formatos = new List<Formatos>();
var lista_pagos = new List<Pagos>();
var lista_ordenes = new List<Ordenes>();
var lista_marcas = new List<Marcas>();
var lista_ordenes_discos = new List<OrdenesDiscos>();

//LISTA DE CLIENTES
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
//LISTA DE ARTISTAS
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
//LISTA DE MARCAS
lista_marcas.Add(new Marcas()
{
    IdMarca = "1",
    NombreMarca = "Sony",
    PaginaWeb = "https://surl.li/thlena"
});
lista_marcas.Add(new Marcas()
{
    IdMarca = "2",
    NombreMarca = "Warner",
    PaginaWeb = "https://warner.com"
});
lista_marcas.Add(new Marcas()
{
    IdMarca = "3",
    NombreMarca = "4 AD",
    PaginaWeb = "https://4AD.com"
});
//LISTA DE DISCOS
lista_discos.Add(new Discos()
{
    IdDisco = "D001",
    Artista = "A001",
    Marca = "1",
    NombreDisco = "Love Street",
    FechaLanzamiento = new DateTime(1968, 7, 2),
    Descripcion = "Escrita por Jim",
    _Artista = lista_artistas[0],
    _Marcas = lista_marcas[0]
});
lista_discos.Add(new Discos()
{
    IdDisco = "D002",
    Artista = "A002",
    Marca = "2",
    NombreDisco = "My Way",
    FechaLanzamiento = new DateTime(1969, 8, 10),
    Descripcion = "Inspirada en una pelicula",
    _Artista = lista_artistas[1],
    _Marcas = lista_marcas[1]
});
lista_discos.Add(new Discos()
{
    IdDisco = "D003",
    Artista = "A003",
    Marca = "1",
    NombreDisco = "7 Rings",
    FechaLanzamiento = new DateTime(2019, 1, 18),
    Descripcion = "Inspirada en el empoderamiento, riqueza y amistad.",
    _Artista = lista_artistas[2],
    _Marcas = lista_marcas[0]

});
lista_discos.Add(new Discos()
{
    IdDisco = "D004",
    Artista = "A004",
    Marca = "3",
    NombreDisco = "I Wonder",
    FechaLanzamiento = new DateTime(1967, 5, 3),
    Descripcion = "Inspirada en la búsqueda de los sueños y la ambición",
    _Artista = lista_artistas[3],
    _Marcas = lista_marcas[2]

});
//LISTA DE FORMATOS
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
//LISTA DE PAGOS
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
//LISTA DE ORDENES
lista_ordenes.Add(new Ordenes()
{
    IdOrden = "AAAA",
    Fecha = new DateTime(2024, 12, 10),
    Cliente = "C001",
    Pago = "P001",
    MontoTotal = 1000,
    _Cliente = lista_clientes[0],
    _Pago = lista_pagos[0]
});
lista_ordenes.Add(new Ordenes()
{
    IdOrden = "BBBB",
    Fecha = new DateTime(2024, 11, 2),
    Cliente = "C002",
    Pago = "P002",
    MontoTotal = 2000,
    _Cliente = lista_clientes[1],
    _Pago = lista_pagos[1]
});
lista_ordenes.Add(new Ordenes()
{
    IdOrden = "CCCC",
    Fecha = new DateTime(2024, 12, 3),
    Cliente = "C003",
    Pago = "P001",
    MontoTotal = 3000,
    _Cliente = lista_clientes[2],
    _Pago = lista_pagos[0]
});
//LISTA DE ORDENES DISCOS
lista_ordenes_discos.Add(new OrdenesDiscos()
{
    IdOrdenDisco = "1000",
    Orden = "AAAA",
    Disco = "D001",
    Formato = "F001",
    Cantidad = 1,
    ValorUnitario = 100,
    _Orden = lista_ordenes[0],
    _Disco = lista_discos[0],
    _Formato = lista_formatos[0]
});
lista_ordenes_discos.Add(new OrdenesDiscos()
{
    IdOrdenDisco = "2000",
    Orden = "AAAA",
    Disco = "D002",
    Formato = "F002",
    Cantidad = 1,
    ValorUnitario = 50,
    _Orden = lista_ordenes[0],
    _Disco = lista_discos[1],
    _Formato = lista_formatos[1]
});
lista_ordenes_discos.Add(new OrdenesDiscos()
{
    IdOrdenDisco = "3000",
    Orden = "BBBB",
    Disco = "D003",
    Formato = "F001",
    Cantidad = 2,
    ValorUnitario = 130,
    _Orden = lista_ordenes[1],
    _Disco = lista_discos[2],
    _Formato = lista_formatos[0]
});
lista_ordenes_discos.Add(new OrdenesDiscos()
{
    IdOrdenDisco = "4000",
    Orden = "BBBB",
    Disco = "D004",
    Formato = "F001",
    Cantidad = 1,
    ValorUnitario = 100,
    _Orden = lista_ordenes[1],
    _Disco = lista_discos[3],
    _Formato = lista_formatos[0]
});
lista_ordenes_discos.Add(new OrdenesDiscos()
{
    IdOrdenDisco = "5000",
    Orden = "CCCC",
    Disco = "D002",
    Formato = "F002",
    Cantidad = 2,
    ValorUnitario = 50,
    _Orden = lista_ordenes[2],
    _Disco = lista_discos[1],
    _Formato = lista_formatos[1]
});

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
    public string? Marca { get; set; }//Id del formato clave marca
    public string? NombreDisco { get; set; }
    public DateTime FechaLanzamiento { get; set; }
    public string? Descripcion { get; set; }
    public Artistas? _Artista { get; set; } // Propiedad de navegación para acceder a los datos del artista
    public Marcas? _Marcas { get; set; }// Propiedad de navegación para acceder a los datos de la marca
    public List<OrdenesDiscos>? OrdenesDiscos { get; set; } //Relacion 1:M con ordenes_discos

}
public class Formatos
{
    public string? IdFormato { get; set; }
    public string? TipoFormato { get; set; }
    public string? Material { get; set; }
    public List<OrdenesDiscos>? OrdenesDiscos { get; set; } //Relacion 1:M con ordenes discos

}
public class Pagos
{
    public string? IdPago { get; set; }
    public string? TipoPago { get; set; }
    //Falta atributo

}
public class Ordenes
{
    public string? IdOrden { get; set; }
    public DateTime Fecha { get; set; }
    public string? Cliente { get; set; } //Id del cliente clave foranea
    public string? Pago { get; set; } //Id del pago clave foranea
    public double MontoTotal { get; set; }
    public Clientes? _Cliente { get; set; } // Propiedad de navegación para acceder a los datos del cliente
    public Pagos? _Pago { get; set; } // Propiedad de navegación para acceder a los datos del pago
    public List<OrdenesDiscos>? OrdenesDiscos { get; set; } //Relacion 1:M con ordenes discos

}

public class OrdenesDiscos
{
    public string? IdOrdenDisco { get; set; }
    public string? Orden { get; set; } //Id de la orden clave foranea
    public string? Disco { get; set; } //Id del disco clave foranea
    public string? Formato { get; set; } //Id del formato clave foranea
    public int Cantidad { get; set; }
    public double ValorUnitario { get; set; }
    public Ordenes? _Orden { get; set; } // Propiedad de navegación para acceder a los datos de las ordenes
    public Discos? _Disco { get; set; } // Propiedad de navegación para acceder a los datos del disco
    public Formatos? _Formato { get; set; } // Propiedad de navegación para acceder a los datos del formato

}
public class Marcas
{
    public string? IdMarca { get; set; }
    public string? NombreMarca { get; set; }
    public string? PaginaWeb { get; set; }
    public List<Discos>? Discos { get; set; } //Relacion 1:M con discos
}

