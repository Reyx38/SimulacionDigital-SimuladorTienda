namespace SimulacionDigital_SimuladorTienda.Modelos;
public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public int Cantidad { get; set; }
    public float SubTotal { get; set; }
    public float ProbabilidadVenta { get; set; }
    public float MargenBeneficio { get; set; }
    public float PrecioUnitario => SubTotal / Cantidad;
    public float GastosAdicionales => SubTotal > 0 ? SubTotal * (0.15F) : 0;
    public float CostoUnitario => Cantidad > 0 ? ((SubTotal) + GastosAdicionales) / Cantidad : 0;
    public float PrecioVenta => CostoUnitario * (1 + MargenBeneficio / 100);
}
