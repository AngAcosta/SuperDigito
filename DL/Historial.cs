using System;
using System.Collections.Generic;

namespace DL;

public partial class Historial
{
    public int IdHistorial { get; set; }

    public string? Numero { get; set; }

    public string? Resultado { get; set; }

    public DateTime? FechaHora { get; set; }
}
