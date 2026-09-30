var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});


builder.Services.AddOpenApi();


var app = builder.Build();


app.UseCors();
app.MapGet("/", () =>
{
    return "API Venta de abarrotes funcionando";
});


app.MapGet("/api/VentaAbarrotes", () =>
{
    return Results.Ok(new[]
    {
        new { id = "metro_0", nombre = "Sixpack Leche Reconstituida Gloria Lata 390g ", marca = "Sixpack Leche Reconstituida Gloria Lata 390g ", precio = "S/ 21.80", imagen = "https://metroio.vtexassets.com/arquivos/pixel.png" },
        new { id = "metro_1", nombre = "Tripack Leche Entera UHT Gloria Caja 946ml ", marca = "Tripack Leche Entera UHT Gloria Caja 946ml ", precio = "S/ 15.80", imagen = "https://metroio.vtexassets.com/arquivos/pixel.png" },
        new { id = "metro_2", nombre = "Tripack Leche UHT Sin Lactosa Gloria Zero Lacto Caja 946ml ", marca = "Tripack Leche UHT Sin Lactosa Gloria Zero Lacto Caja 946ml ", precio = "S/ 16.20", imagen = "https://metroio.vtexassets.com/arquivos/pixel.png" },
        new { id = "metro_3", nombre = "Sixpack Leche Light Laive Sin Lactosa Botella 390g ", marca = "Sixpack Leche Light Laive Sin Lactosa Botella 390g ", precio = "S/ 23.50", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_4", nombre = "Tripack Leche Entera UHT Gloria Bolsa 800ml ", marca = "Tripack Leche Entera UHT Gloria Bolsa 800ml ", precio = "S/ 13.40", imagen = "https://metroio.vtexassets.com/arquivos/pixel.png" },
        new { id = "metro_5", nombre = "Sixpack Leche Reconstituida Gloria Light Lata 390g ", marca = "Sixpack Leche Reconstituida Gloria Light Lata 390g ", precio = "S/ 23.00", imagen = "https://metroio.vtexassets.com/arquivos/pixel.png" },
        new { id = "metro_6", nombre = "Sixpack Leche para Diluir Laive Sin Lactosa Botella 390g ", marca = "Sixpack Leche para Diluir Laive Sin Lactosa Botella 390g ", precio = "S/ 23.50", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_7", nombre = "Sixpack Leche Ultrafiltrada Sin Lactosa Gloria Zero Lacto Lata 390g ", marca = "Sixpack Leche Ultrafiltrada Sin Lactosa Gloria Zero Lacto Lata 390g ", precio = "S/ 25.90", imagen = "https://metroio.vtexassets.com/arquivos/pixel.png" },
        new { id = "metro_8", nombre = "Pack x6 Leche Evaporada Gloria Entera ", marca = "Pack x6 Leche Evaporada Gloria Entera ", precio = "S/ 24.90", imagen = "https://metroio.vtexassets.com/arquivos/pixel.png" },
        new { id = "metro_9", nombre = "Fourpack Leche Semidescremada UHT Laive Sin Lactosa Caja 946ml ", marca = "Fourpack Leche Semidescremada UHT Laive Sin Lactosa Caja 946ml ", precio = "S/ 20.50", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_10", nombre = "Leche Entera Pasteurizada Danlac Botella 900ml ", marca = "Leche Entera Pasteurizada Danlac Botella 900ml ", precio = "S/ 8.10", imagen = "https://metroio.vtexassets.com/arquivos/ids/248431-144-144?v=638173947762730000&width=144&height=144&aspect=true" },
        new { id = "metro_11", nombre = "Sixpack Leche Light Gloria Zero Lacto Lata 390g ", marca = "Sixpack Leche Light Gloria Zero Lacto Lata 390g ", precio = "S/ 22.90", imagen = "https://metroio.vtexassets.com/arquivos/pixel.png" },
        new { id = "metro_12", nombre = "Tripack Leche UHT Gloria Light Caja 946ml ", marca = "Tripack Leche UHT Gloria Light Caja 946ml ", precio = "S/ 16.50", imagen = "https://metroio.vtexassets.com/arquivos/pixel.png" },
        new { id = "metro_13", nombre = "Leche Reconstituida Gloria Lata 390g ", marca = "Leche Reconstituida Gloria Lata 390g ", precio = "S/ 4.50", imagen = "https://metroio.vtexassets.com/arquivos/pixel.png" },
        new { id = "metro_14", nombre = "Leche Light Laive Sin Lactosa Botella 390g ", marca = "Leche Light Laive Sin Lactosa Botella 390g ", precio = "S/ 4.90", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_15", nombre = "Leche Ultrafiltrada Sin Lactosa Gloria Zero Lacto Lata 390g ", marca = "Leche Ultrafiltrada Sin Lactosa Gloria Zero Lacto Lata 390g ", precio = "S/ 4.50", imagen = "https://metroio.vtexassets.com/arquivos/pixel.png" },
        new { id = "metro_16", nombre = "Sixpack Leche Reconstituida con Vitaminas Gloria Lata 170g ", marca = "Sixpack Leche Reconstituida con Vitaminas Gloria Lata 170g ", precio = "S/ 12.90", imagen = "https://metroio.vtexassets.com/arquivos/pixel.png" },
        new { id = "metro_17", nombre = "Tripack Leche UHT Descremada Gloria Slim Triple Zero Caja 946ml ", marca = "Tripack Leche UHT Descremada Gloria Slim Triple Zero Caja 946ml ", precio = "S/ 16.30", imagen = "https://metroio.vtexassets.com/arquivos/pixel.png" },
        new { id = "metro_18", nombre = "Leche Parcialmente Descremada UHT Gloria Zero Lacto ", marca = "Leche Parcialmente Descremada UHT Gloria Zero Lacto ", precio = "S/ 13.90", imagen = "https://metroio.vtexassets.com/arquivos/pixel.png" },
        new { id = "metro_19", nombre = "Sixpack Leche Gloria Niños Lata 390g ", marca = "Sixpack Leche Gloria Niños Lata 390g ", precio = "S/ 22.90", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_20", nombre = "Leche Uht Vigor Bolsa 800ml ", marca = "Leche Uht Vigor Bolsa 800ml ", precio = "S/ 5.30", imagen = "https://metroio.vtexassets.com/arquivos/ids/393571-144-144?v=638180614113630000&width=144&height=144&aspect=true" },
        new { id = "metro_21", nombre = "Leche Semidescremada UHT Laive Sin Lactosa Caja 946ml ", marca = "Leche Semidescremada UHT Laive Sin Lactosa Caja 946ml ", precio = "S/ 5.90", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_22", nombre = "Leche Evaporada Entera Cuisine & Co Lata 410g ", marca = "Leche Evaporada Entera Cuisine & Co Lata 410g ", precio = "S/ 4.10", imagen = "https://metroio.vtexassets.com/arquivos/pixel.png" },
        new { id = "metro_23", nombre = "Leche Reconstituida Gloria Light Lata 390g ", marca = "Leche Reconstituida Gloria Light Lata 390g ", precio = "S/ 4.50", imagen = "https://metroio.vtexassets.com/arquivos/pixel.png" },
        new { id = "metro_24", nombre = "Leche Sabor Chocolate Gloria Caja 946ml ", marca = "Leche Sabor Chocolate Gloria Caja 946ml ", precio = "S/ 7.20", imagen = "https://metroio.vtexassets.com/arquivos/pixel.png" },
        new { id = "metro_25", nombre = "Leche Descremada UHT Laive Sbelt Caja 946ml ", marca = "Leche Descremada UHT Laive Sbelt Caja 946ml ", precio = "S/ 5.90", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_26", nombre = "Pack x6 Mezcla Láctea Laive Sin Lactosa 480g ", marca = "Pack x6 Mezcla Láctea Laive Sin Lactosa 480g ", precio = "S/ 23.40", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_27", nombre = "Leche Concentrada Sin Lactosa Laive Botella 390g ", marca = "Leche Concentrada Sin Lactosa Laive Botella 390g ", precio = "S/ 4.90", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_28", nombre = "Leche Parcialmente Descremada Gloria Light Bolsa 800ml ", marca = "Leche Parcialmente Descremada Gloria Light Bolsa 800ml ", precio = "S/ 4.70", imagen = "https://metroio.vtexassets.com/arquivos/coleman-D.png" },
        new { id = "metro_29", nombre = "Leche UHT Laive Bolsa 800ml ", marca = "Leche UHT Laive Bolsa 800ml ", precio = "S/ 4.80", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_30", nombre = "Leche Deslactosada Danlac Light Botella 900ml ", marca = "Leche Deslactosada Danlac Light Botella 900ml ", precio = "S/ 9.00", imagen = "https://metroio.vtexassets.com/arquivos/ids/530256-144-144?v=638526551456070000&width=144&height=144&aspect=true" },
        new { id = "metro_31", nombre = "Leche Evaporada Bella Holandesa Lata 405g ", marca = "Leche Evaporada Bella Holandesa Lata 405g ", precio = "S/ 3.40", imagen = "https://metroio.vtexassets.com/arquivos/ids/643882-144-144?v=639130164824000000&width=144&height=144&aspect=true" },
        new { id = "metro_32", nombre = "Sixpack Mezcla Láctea Ideal Cremosita Lata 390g ", marca = "Sixpack Mezcla Láctea Ideal Cremosita Lata 390g ", precio = "S/ 22.90", imagen = "https://metroio.vtexassets.com/arquivos/ids/587848-144-144?v=638833593680100000&width=144&height=144&aspect=true" },
        new { id = "metro_33", nombre = "Leche Entera UHT Gloria Caja 946ml ", marca = "Leche Entera UHT Gloria Caja 946ml ", precio = "S/ 6.50", imagen = "https://metroio.vtexassets.com/arquivos/coleman-D.png" },
        new { id = "metro_34", nombre = "Leche Fresca Piamonte Bolsa 950 ml ", marca = "Leche Fresca Piamonte Bolsa 950 ml ", precio = "S/ 6.50", imagen = "https://metroio.vtexassets.com/arquivos/coleman-D.png" },
        new { id = "metro_35", nombre = "Fourpack Leche Entera UHT Laive Caja 946ml ", marca = "Fourpack Leche Entera UHT Laive Caja 946ml ", precio = "S/ 20.90", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_36", nombre = "Leche UHT Milkito Bolsa 800ml ", marca = "Leche UHT Milkito Bolsa 800ml ", precio = "S/ 4.80", imagen = "https://metroio.vtexassets.com/arquivos/ids/633979-144-144?v=639068601969270000&width=144&height=144&aspect=true" },
        new { id = "metro_37", nombre = "Sixpack Mezcla Láctea Bonlé Familiar Caja 480g ", marca = "Sixpack Mezcla Láctea Bonlé Familiar Caja 480g ", precio = "S/ 19.70", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_38", nombre = "Leche UHT Sin Lactosa Gloria Zero Lacto Caja 946ml ", marca = "Leche UHT Sin Lactosa Gloria Zero Lacto Caja 946ml ", precio = "S/ 6.50", imagen = "https://metroio.vtexassets.com/arquivos/coleman-D.png" },
        new { id = "metro_39", nombre = "Tripack Leche Parcialmente Descremada Gloria Niños Caja 946ml ", marca = "Tripack Leche Parcialmente Descremada Gloria Niños Caja 946ml ", precio = "S/ 16.30", imagen = "https://metroio.vtexassets.com/arquivos/coleman-D.png" },
        new { id = "metro_40", nombre = "Sixpack Leche para Diluir Laive Botella 390g ", marca = "Sixpack Leche para Diluir Laive Botella 390g ", precio = "S/ 24.90", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_41", nombre = "Sixpack Leche Sabor a Chocolate Gloria Niños Caja 180ml ", marca = "Sixpack Leche Sabor a Chocolate Gloria Niños Caja 180ml ", precio = "S/ 12.70", imagen = "https://metroio.vtexassets.com/arquivos/coleman-D.png" },
        new { id = "metro_42", nombre = "Sixpack Mezcla Láctea Sin Lactosa Bonlé Caja 480g ", marca = "Sixpack Mezcla Láctea Sin Lactosa Bonlé Caja 480g ", precio = "S/ 19.30", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_43", nombre = "Fourpack Leche Semidescremada UHT Laive Sin Lactosa Light Caja 946ml ", marca = "Fourpack Leche Semidescremada UHT Laive Sin Lactosa Light Caja 946ml ", precio = "S/ 23.90", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_44", nombre = "Leche Evaporada Light Cuisine & Co Lata 410g ", marca = "Leche Evaporada Light Cuisine & Co Lata 410g ", precio = "S/ 4.20", imagen = "https://metroio.vtexassets.com/arquivos/coleman-D.png" },
        new { id = "metro_45", nombre = "Leche UHT Gloria Light Caja 946ml ", marca = "Leche UHT Gloria Light Caja 946ml ", precio = "S/ 6.50", imagen = "https://metroio.vtexassets.com/arquivos/coleman-D.png" },
        new { id = "metro_46", nombre = "Leche Entera UHT Laive Caja 946ml ", marca = "Leche Entera UHT Laive Caja 946ml ", precio = "S/ 5.90", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_47", nombre = "Twelvepack Leche Reconstituida Gloria Lata 390g ", marca = "Twelvepack Leche Reconstituida Gloria Lata 390g ", precio = "S/ 49.20", imagen = "https://metroio.vtexassets.com/arquivos/coleman-D.png" },
        new { id = "metro_48", nombre = "Bebida Láctea Sabor Chocolate Bonlé Bolsa 800 ml ", marca = "Bebida Láctea Sabor Chocolate Bonlé Bolsa 800 ml ", precio = "S/ 3.60", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_49", nombre = "Sixpack Mezcla Láctea Bonlé Protección Lata 390g ", marca = "Sixpack Mezcla Láctea Bonlé Protección Lata 390g ", precio = "S/ 15.00", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_50", nombre = "Leche en Polvo Gloria Bolsa 96g ", marca = "Leche en Polvo Gloria Bolsa 96g ", precio = "S/ 5.70", imagen = "https://metroio.vtexassets.com/arquivos/coleman-D.png" },
        new { id = "metro_51", nombre = "Leche Parcialmente Descremada Gloria Sabor Chocolate Bolsa 900ml ", marca = "Leche Parcialmente Descremada Gloria Sabor Chocolate Bolsa 900ml ", precio = "S/ 6.40", imagen = "https://metroio.vtexassets.com/arquivos/coleman-D.png" },
        new { id = "metro_52", nombre = "Leche Semidescremada UHT Laive Sin Lactosa Light Caja 946ml ", marca = "Leche Semidescremada UHT Laive Sin Lactosa Light Caja 946ml ", precio = "S/ 5.90", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_53", nombre = "Pack x6 Gloria Leche Light 170g ", marca = "Pack x6 Gloria Leche Light 170g ", precio = "S/ 12.90", imagen = "https://metroio.vtexassets.com/arquivos/coleman-D.png" },
        new { id = "metro_54", nombre = "Leche Entera UHT Gloria Bolsa 800ml ", marca = "Leche Entera UHT Gloria Bolsa 800ml ", precio = "S/ 4.90", imagen = "https://metroio.vtexassets.com/arquivos/coleman-D.png" },
        new { id = "metro_55", nombre = "Leche UHT Sin Lactosa Deslactosada Vigor Bolsa 800ml ", marca = "Leche UHT Sin Lactosa Deslactosada Vigor Bolsa 800ml ", precio = "S/ 5.50", imagen = "https://metroio.vtexassets.com/arquivos/ids/563863-144-144?v=638706262986330000&width=144&height=144&aspect=true" },
        new { id = "metro_56", nombre = "Leche para Diluir Laive Botella 390g ", marca = "Leche para Diluir Laive Botella 390g ", precio = "S/ 4.70", imagen = "https://metroio.vtexassets.com/arquivos/TAG-TAURUS-2026.png" },
        new { id = "metro_57", nombre = "Leche UHT Entera Cuisine & Co Caja 1 lt ", marca = "Leche UHT Entera Cuisine & Co Caja 1 lt ", precio = "S/ 5.90", imagen = "https://metroio.vtexassets.com/arquivos/coleman-D.png" },
        new { id = "metro_58", nombre = "Sixpack Leche con Avena y Canela Gloria Acti Avena Caja 180ml ", marca = "Sixpack Leche con Avena y Canela Gloria Acti Avena Caja 180ml ", precio = "S/ 11.90", imagen = "https://metroio.vtexassets.com/arquivos/coleman-D.png" },
        new { id = "metro_59", nombre = "Sixpack Leche Reconstituida con Quinua , Kiwicha y Cañihua Gloria 390g ", marca = "Sixpack Leche Reconstituida con Quinua , Kiwicha y Cañihua Gloria 390g ", precio = "S/ 22.20", imagen = "https://metroio.vtexassets.com/arquivos/coleman-D.png" }

    });
});


var port = Environment.GetEnvironmentVariable("PORT") ?? "1000";


app.Run($"http://0.0.0.0:{port}");
