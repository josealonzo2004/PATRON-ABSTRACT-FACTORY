

// Interfaz abstracta para la fábrica de vehículos
public abstract class IFabricaVehiculos
{
    // Método para crear un objeto de la interfaz IAutomovil
    public abstract IAutomovil CrearAutomovil();
    
    // Método para crear un objeto de la interfaz IMotocicleta
    public abstract IMotocicleta CrearMotocicleta();
}