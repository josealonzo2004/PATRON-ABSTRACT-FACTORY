

// Clase concreta para la fábrica de vehículos de lujo
public class FabricaVehiculosDeLujo : IFabricaVehiculos
{
    // Implementación del método para crear un automóvil de lujo
    public override IAutomovil CrearAutomovil()
    {
        // Retorna una nueva instancia de AutomovilDeLujo, que implementa IAutomovil
        return new AutomovilDeLujo();
    }

    // Implementación del método para crear una motocicleta deportiva
    public override IMotocicleta CrearMotocicleta()
    {
        // Retorna una nueva instancia de MotocicletaDeportiva, que implementa IMotocicleta
        return new MotocicletaDeportiva();
    }
}