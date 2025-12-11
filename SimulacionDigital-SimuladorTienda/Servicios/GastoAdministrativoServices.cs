using SimulacionDigital_SimuladorTienda.Modelos;

namespace SimulacionDigital_SimuladorTienda.Servicios;

public class GastoAdministrativoServices
{
    public List<GastoAdministrativo> InicializarGastosAdministrativos()
    {
        return new List<GastoAdministrativo>
         {
             new GastoAdministrativo { Id = 1, Descripcion = "Renta", Valor = 20000 },
             new GastoAdministrativo { Id = 2, Descripcion = "Energia Electrica", Valor = 5500 },
             new GastoAdministrativo { Id = 1, Descripcion = "Internet", Valor = 2200 },
             new GastoAdministrativo { Id = 2, Descripcion = "Publicidad Digital", Valor = 5000 }
         };
    }

    public float gastosDiarios(List<GastoAdministrativo> gastoAdministrativo)
    {
        float gastoAdministrativos = gastoAdministrativo.Sum(x => x.Valor) / 30f;
        return gastoAdministrativos;
    }
}
