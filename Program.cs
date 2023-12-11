class Programa
{
    static void Main()
    {
        // Creamos una fábrica de vehículos de lujo
        IFabricaVehiculos fabricaDeLujo = new FabricaVehiculosDeLujo();

        // Creamos un automóvil y una motocicleta de lujo
        IAutomovil automovilLujo = fabricaDeLujo.CrearAutomovil();
        IMotocicleta motocicletaDeportiva = fabricaDeLujo.CrearMotocicleta();

        // Probamos los productos creados
        automovilLujo.Arrancar();
        motocicletaDeportiva.Iniciar();

        // Salida esperada:
        // El auto arranco correctamente
        // La motocicleta inicio su encendido
    }
}