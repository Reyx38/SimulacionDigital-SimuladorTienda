using SimulacionDigital_SimuladorTienda.Modelos;

namespace SimulacionDigital_SimuladorTienda.Servicios;

public class EmpleadoServices
{
    public List<Empleado> InicializarEmpleados()
    {
        return new List<Empleado>
        {
            new Empleado { Id = 1, Nombre = "Juan Pérez", Puesto = "Vendedor", Salario = 10500 },
            new Empleado { Id = 2, Nombre = "María López", Puesto = "Limpieza", Salario = 8500 },
            new Empleado { Id = 1, Nombre = "Juana Pérez", Puesto = "Vendedora", Salario = 10500 },
            new Empleado { Id = 2, Nombre = "Juan Duarte", Puesto = "Cajero", Salario = 8500 },
            new Empleado { Id = 1, Nombre = "Pedro Perez", Puesto = "Contador", Salario = 3500 },
            new Empleado { Id = 2, Nombre = "Limpieza", Puesto = "Vendedor", Salario = 7000 }
        };
    }

    public float gastosDiarios(List<Empleado> empleados)
    {
        float gastoEmpleados = empleados.Sum(x => x.Salario) / 30f;
        return gastoEmpleados;
    }

}
