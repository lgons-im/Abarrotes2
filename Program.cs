var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.AddOpenApi();

var app = builder.Build();

app.UseCors();

app.MapGet("/", () => "API Venta de abarrotes funcionando");

const string PX = "https://metroio.vtexassets.com/arquivos/pixel.png";
const string TAG = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png";
const string COL = "https://metroio.vtexassets.com/arquivos/coleman-D.png";

static Producto P(string id, string nombre, string precio, string imagen) =>
    new Producto { Id = id, Nombre = nombre, Marca = nombre, Precio = precio, Imagen = imagen };

var productos = new List<Producto>
{
    P("metro_0", "Sixpack Leche Reconstituida Gloria Lata 390g", "S/ 21.80", PX),
    P("metro_1", "Tripack Leche Entera UHT Gloria Caja 946ml", "S/ 15.80", PX),
    P("metro_2", "Tripack Leche UHT Sin Lactosa Gloria Zero Lacto Caja 946ml", "S/ 16.20", PX),
    P("metro_3", "Sixpack Leche Light Laive Sin Lactosa Botella 390g", "S/ 23.50", TAG),
    P("metro_4", "Tripack Leche Entera UHT Gloria Bolsa 800ml", "S/ 13.40", PX),
    P("metro_5", "Sixpack Leche Reconstituida Gloria Light Lata 390g", "S/ 23.00", PX),
    P("metro_6", "Sixpack Leche para Diluir Laive Sin Lactosa Botella 390g", "S/ 23.50", TAG),
    P("metro_7", "Sixpack Leche Ultrafiltrada Sin Lactosa Gloria Zero Lacto Lata 390g", "S/ 25.90", PX),
    P("metro_8", "Pack x6 Leche Evaporada Gloria Entera", "S/ 24.90", PX),
    P("metro_9", "Fourpack Leche Semidescremada UHT Laive Sin Lactosa Caja 946ml", "S/ 20.50", TAG),
    P("metro_10", "Leche Entera Pasteurizada Danlac Botella 900ml", "S/ 8.10", "https://metroio.vtexassets.com/arquivos/ids/248431-144-144?v=638173947762730000&width=144&height=144&aspect=true"),
    P("metro_11", "Sixpack Leche Light Gloria Zero Lacto Lata 390g", "S/ 22.90", PX),
    P("metro_12", "Tripack Leche UHT Gloria Light Caja 946ml", "S/ 16.50", PX),
    P("metro_13", "Leche Reconstituida Gloria Lata 390g", "S/ 4.50", PX),
    P("metro_14", "Leche Light Laive Sin Lactosa Botella 390g", "S/ 4.90", TAG),
    P("metro_15", "Leche Ultrafiltrada Sin Lactosa Gloria Zero Lacto Lata 390g", "S/ 4.50", PX),
    P("metro_16", "Sixpack Leche Reconstituida con Vitaminas Gloria Lata 170g", "S/ 12.90", PX),
    P("metro_17", "Tripack Leche UHT Descremada Gloria Slim Triple Zero Caja 946ml", "S/ 16.30", PX),
    P("metro_18", "Leche Parcialmente Descremada UHT Gloria Zero Lacto", "S/ 13.90", PX),
    P("metro_19", "Sixpack Leche Gloria Niños Lata 390g", "S/ 22.90", TAG),
    P("metro_20", "Leche Uht Vigor Bolsa 800ml", "S/ 5.30", "https://metroio.vtexassets.com/arquivos/ids/393571-144-144?v=638180614113630000&width=144&height=144&aspect=true"),
    P("metro_21", "Leche Semidescremada UHT Laive Sin Lactosa Caja 946ml", "S/ 5.90", TAG),
    P("metro_22", "Leche Evaporada Entera Cuisine & Co Lata 410g", "S/ 4.10", PX),
    P("metro_23", "Leche Reconstituida Gloria Light Lata 390g", "S/ 4.50", PX),
    P("metro_24", "Leche Sabor Chocolate Gloria Caja 946ml", "S/ 7.20", PX),
    P("metro_25", "Leche Descremada UHT Laive Sbelt Caja 946ml", "S/ 5.90", TAG),
    P("metro_26", "Pack x6 Mezcla Láctea Laive Sin Lactosa 480g", "S/ 23.40", TAG),
    P("metro_27", "Leche Concentrada Sin Lactosa Laive Botella 390g", "S/ 4.90", TAG),
    P("metro_28", "Leche Parcialmente Descremada Gloria Light Bolsa 800ml", "S/ 4.70", COL),
    P("metro_29", "Leche UHT Laive Bolsa 800ml", "S/ 4.80", TAG),
    P("metro_30", "Leche Deslactosada Danlac Light Botella 900ml", "S/ 9.00", "https://metroio.vtexassets.com/arquivos/ids/530256-144-144?v=638526551456070000&width=144&height=144&aspect=true"),
    P("metro_31", "Leche Evaporada Bella Holandesa Lata 405g", "S/ 3.40", "https://metroio.vtexassets.com/arquivos/ids/643882-144-144?v=639130164824000000&width=144&height=144&aspect=true"),
    P("metro_32", "Sixpack Mezcla Láctea Ideal Cremosita Lata 390g", "S/ 22.90", "https://metroio.vtexassets.com/arquivos/ids/587848-144-144?v=638833593680100000&width=144&height=144&aspect=true"),
    P("metro_33", "Leche Entera UHT Gloria Caja 946ml", "S/ 6.50", COL),
    P("metro_34", "Leche Fresca Piamonte Bolsa 950 ml", "S/ 6.50", COL),
    P("metro_35", "Fourpack Leche Entera UHT Laive Caja 946ml", "S/ 20.90", TAG),
    P("metro_36", "Leche UHT Milkito Bolsa 800ml", "S/ 4.80", "https://metroio.vtexassets.com/arquivos/ids/633979-144-144?v=639068601969270000&width=144&height=144&aspect=true"),
    P("metro_37", "Sixpack Mezcla Láctea Bonlé Familiar Caja 480g", "S/ 19.70", TAG),
    P("metro_38", "Leche UHT Sin Lactosa Gloria Zero Lacto Caja 946ml", "S/ 6.50", COL),
    P("metro_39", "Tripack Leche Parcialmente Descremada Gloria Niños Caja 946ml", "S/ 16.30", COL),
    P("metro_40", "Sixpack Leche para Diluir Laive Botella 390g", "S/ 24.90", TAG),
    P("metro_41", "Sixpack Leche Sabor a Chocolate Gloria Niños Caja 180ml", "S/ 12.70", COL),
    P("metro_42", "Sixpack Mezcla Láctea Sin Lactosa Bonlé Caja 480g", "S/ 19.30", TAG),
    P("metro_43", "Fourpack Leche Semidescremada UHT Laive Sin Lactosa Light Caja 946ml", "S/ 23.90", TAG),
    P("metro_44", "Leche Evaporada Light Cuisine & Co Lata 410g", "S/ 4.20", COL),
    P("metro_45", "Leche UHT Gloria Light Caja 946ml", "S/ 6.50", COL),
    P("metro_46", "Leche Entera UHT Laive Caja 946ml", "S/ 5.90", TAG),
    P("metro_47", "Twelvepack Leche Reconstituida Gloria Lata 390g", "S/ 49.20", COL),
    P("metro_48", "Bebida Láctea Sabor Chocolate Bonlé Bolsa 800 ml", "S/ 3.60", TAG),
    P("metro_49", "Sixpack Mezcla Láctea Bonlé Protección Lata 390g", "S/ 15.00", TAG),
    P("metro_50", "Leche en Polvo Gloria Bolsa 96g", "S/ 5.70", COL),
    P("metro_51", "Leche Parcialmente Descremada Gloria Sabor Chocolate Bolsa 900ml", "S/ 6.40", COL),
    P("metro_52", "Leche Semidescremada UHT Laive Sin Lactosa Light Caja 946ml", "S/ 5.90", TAG),
    P("metro_53", "Pack x6 Gloria Leche Light 170g", "S/ 12.90", COL),
    P("metro_54", "Leche Entera UHT Gloria Bolsa 800ml", "S/ 4.90", COL),
    P("metro_55", "Leche UHT Sin Lactosa Deslactosada Vigor Bolsa 800ml", "S/ 5.50", "https://metroio.vtexassets.com/arquivos/ids/563863-144-144?v=638706262986330000&width=144&height=144&aspect=true"),
    P("metro_56", "Leche para Diluir Laive Botella 390g", "S/ 4.70", TAG),
    P("metro_57", "Leche UHT Entera Cuisine & Co Caja 1 lt", "S/ 5.90", COL),
    P("metro_58", "Sixpack Leche con Avena y Canela Gloria Acti Avena Caja 180ml", "S/ 11.90", COL),
    P("metro_59", "Sixpack Leche Reconstituida con Quinua , Kiwicha y Cañihua Gloria 390g", "S/ 22.20", COL)
};

var siguienteId = productos.Count; // el próximo será metro_60

// El CRUD se registra en dos rutas: /api/VentaAbarrotes y /api/productos
foreach (var ruta in new[] { "/api/VentaAbarrotes", "/api/productos" })
{
    // GET: listar todos
    app.MapGet(ruta, () => Results.Ok(productos));

    // GET: uno por id
    app.MapGet(ruta + "/{id}", (string id) =>
    {
        var p = productos.FirstOrDefault(x => x.Id == id);
        return p is null
            ? Results.NotFound(new { mensaje = $"No existe el producto {id}" })
            : Results.Ok(p);
    });

    // POST: crear
    app.MapPost(ruta, (Producto nuevo) =>
    {
        if (string.IsNullOrWhiteSpace(nuevo.Nombre))
            return Results.BadRequest(new { mensaje = "El nombre es obligatorio" });

        nuevo.Id = $"metro_{siguienteId++}";
        productos.Add(nuevo);
        return Results.Created($"{ruta}/{nuevo.Id}", nuevo);
    });

    // PUT: actualizar
    app.MapPut(ruta + "/{id}", (string id, Producto datos) =>
    {
        var p = productos.FirstOrDefault(x => x.Id == id);
        if (p is null)
            return Results.NotFound(new { mensaje = $"No existe el producto {id}" });

        p.Nombre = datos.Nombre;
        p.Marca = datos.Marca;
        p.Precio = datos.Precio;
        p.Imagen = datos.Imagen;
        return Results.Ok(p);
    });

    // DELETE: eliminar
    app.MapDelete(ruta + "/{id}", (string id) =>
    {
        var p = productos.FirstOrDefault(x => x.Id == id);
        if (p is null)
            return Results.NotFound(new { mensaje = $"No existe el producto {id}" });

        productos.Remove(p);
        return Results.Ok(new { mensaje = $"Producto {id} eliminado correctamente", eliminado = p });
    });
}

var port = Environment.GetEnvironmentVariable("PORT") ?? "1000";

app.Run($"http://0.0.0.0:{port}");

public class Producto
{
    public string Id { get; set; } = "";
    public string Nombre { get; set; } = "";
    public string Marca { get; set; } = "";
    public string Precio { get; set; } = "";
    public string Imagen { get; set; } = "";
}
