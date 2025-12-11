namespace SimulacionDigital_SimuladorTienda.Modelos;

public class ResultadoDiario
{
    public int Dia { get; set; }
    public float Ventas { get; set; }
    public float Descuentos { get; set; }
    public float VentasNetas { get; set; }
    public float CostoVentas { get; set; }
    public float IngresosNetos { get; set; }
    public float EmpleadoTotal { get; set; }
    public float GastoADMTotal { get; set; }
    public float GastosMenoresTotal { get; set; }
    public float FinanciamientoTotal { get; set; }
    public float TotalGastos { get; set; }
    public float IngresosBrutos { get; set; }
    public float MargenBeneficio { get; set; }
    public bool ConBeneficios => IngresosBrutos > 0;
}
