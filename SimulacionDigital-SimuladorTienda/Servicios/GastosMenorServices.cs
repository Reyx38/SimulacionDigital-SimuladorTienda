using SimulacionDigital_SimuladorTienda.Modelos;

namespace SimulacionDigital_SimuladorTienda.Servicios;

public class GastosMenorServices
{
    public List<GastoMenor> InicializarGastosMenores()
    {
        return new List<GastoMenor>
        {
            new GastoMenor { Id = 1, Descripcion = "Limpieza", Valor = 2500 },
            new GastoMenor { Id = 2, Descripcion = "Dietas", Valor = 1500 },
            new GastoMenor { Id = 1, Descripcion = "Publicidad", Valor = 10000 },
            new GastoMenor { Id = 2, Descripcion = "Telefonia", Valor = 3000 },
            new GastoMenor { Id = 2, Descripcion = "Motoconcho", Valor = 3000 }
        };
    }
    public float gastosDiarios(List<GastoMenor> gastoMenor)
    {
        float gastosMenor = gastoMenor.Sum(x => x.Valor) / 30f;
        return gastosMenor;
    }
}
