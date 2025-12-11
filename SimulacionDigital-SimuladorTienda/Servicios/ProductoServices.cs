using SimulacionDigital_SimuladorTienda.Modelos;

namespace SimulacionDigital_SimuladorTienda.Servicios;

public class ProductoServices
{

    public List<Producto> InicializarProductos()
    {
        return new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Sueters ADIDAS", Cantidad = 50, SubTotal = 148885, MargenBeneficio = 40, ProbabilidadVenta = 12f },
            new Producto { Id = 2, Nombre = "Boxers CK", Cantidad = 30, SubTotal = 16242, MargenBeneficio = 45 , ProbabilidadVenta = 68f},
            new Producto { Id = 3, Nombre = "Jeans Express", Cantidad = 100, SubTotal = 406050, MargenBeneficio = 35, ProbabilidadVenta = 75f },
            new Producto { Id = 1, Nombre = "Shorts Banana Republic", Cantidad = 50, SubTotal = 162420, MargenBeneficio = 40, ProbabilidadVenta = 70f },
            new Producto { Id = 2, Nombre = "Camisas Perry Ellis", Cantidad = 10, SubTotal = 27070, MargenBeneficio = 45, ProbabilidadVenta = 58f },
            new Producto { Id = 3, Nombre = "Perfumes 30 Cl Gucci", Cantidad = 10, SubTotal = 54140, MargenBeneficio = 35, ProbabilidadVenta = 22f },
            new Producto { Id = 1, Nombre = "Permumes 25 Cl Dolce & Gabanna", Cantidad = 5, SubTotal = 24363, MargenBeneficio = 40,ProbabilidadVenta = 20f },
            new Producto { Id = 2, Nombre = "Perfumes Cocco Chanel 30 Cl", Cantidad = 5, SubTotal = 23009, MargenBeneficio = 45, ProbabilidadVenta = 26f },
            new Producto { Id = 3, Nombre = "Camisas PH", Cantidad = 10, SubTotal = 24363, MargenBeneficio = 35, ProbabilidadVenta = 52f },
            new Producto { Id = 1, Nombre = "Licras Victoria Secret", Cantidad = 50, SubTotal = 21656, MargenBeneficio = 40, ProbabilidadVenta = 46f },
        };
    }
    public float SimularVentaProducto(Producto prod)
    {
        var random = new Random();
        float ingresos = 0;

        float chance = (float)random.NextDouble() * 100;
        if (chance > prod.ProbabilidadVenta)
            return 0; // no se vende hoy

        int maxVenta = Math.Max(1, prod.Cantidad / 10);
        int cantidadVendida = random.Next(1, maxVenta + 1);

        if (cantidadVendida > prod.Cantidad)
            cantidadVendida = prod.Cantidad;


        ingresos = cantidadVendida * prod.PrecioVenta;

        return ingresos;
    }


}
