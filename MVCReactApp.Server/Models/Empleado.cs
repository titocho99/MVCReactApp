using System;
using System.Collections.Generic;

namespace MVCReactApp.Server.Models;

public partial class Empleado
{
    public int IdEmpleados { get; set; }

    public string? Nombre { get; set; }

    public string? Telefono { get; set; }

    public string? Domicilio { get; set; }

    public string? Correo { get; set; }
}
