using SimulacionDigital_SimuladorTienda.Modelos;

namespace SimulacionDigital_SimuladorTienda.Servicios;

public class FinanciamientoServices
{
    public List<Financiamiento> InicializarFinanciamiento()
    {
        return new List<Financiamiento>
        {
           new Financiamiento { Id = 1, Detalle = "Préstamo Bancario", CuotaMensual = 5000 }

        };
    }

}
