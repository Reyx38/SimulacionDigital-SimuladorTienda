namespace SimulacionDigital_SimuladorTienda.Modelos;

public class ResultadoDiario
{
    public int Dia { get; set; }
    public float VentasBrutas { get; set; }
    public float Descuentos { get; set; }
    public float CostoVentas { get; set; }
    public float EmpleadoTotal { get; set; }
    public float GastoADMTotal { get; set; }
    public float GastosMenoresTotal { get; set; }
    public float FinanciamientoTotal { get; set; }
    public float MargenBeneficio { get; set; }
    public float VentasNetas => VentasBrutas - Descuentos ;
    public float TotalGastos => EmpleadoTotal + GastoADMTotal + GastosMenoresTotal + FinanciamientoTotal;
    public float IngresosNeto => IngresosBrutos - TotalGastos;
    public float IngresosBrutos => VentasNetas - CostoVentas;
    public bool ConBeneficios => IngresosNeto > 0;
}
