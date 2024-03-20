namespace Proyecto_ISR.Controller
{
    public class CalculoController
    {
        private readonly List<RangoSueldoTipo> listaRangoSalarial = new()
        {
            new RangoSueldoTipo
            {
                Tipo = 1, //Exento
                RangoAnual = 416220
            },

            new RangoSueldoTipo
            {
                Tipo = 2, //15%
                RangoAnual = 624329
            },

            new RangoSueldoTipo
            {
                Tipo = 3, //20%
                RangoAnual = 867123
            },

            new RangoSueldoTipo
            {
                Tipo = 4, //25%
                RangoAnual = 867123.01m
            }
        };

        public short evaluarSueldo(decimal sueldoActual)
        {
            short tipoRango;
            try
			{
				decimal sueldoAnual = sueldoActual * 12;
                tipoRango = listaRangoSalarial.Where(x => x.RangoAnual >= sueldoActual).Max(x => x.Tipo);
			}
			catch (Exception)
			{
				throw;
			}

            return tipoRango;
        }

        public decimal evaluarSueldo15(decimal sueldoMensual)
{
    decimal impuesto = 0;
    decimal sueldoAnual = sueldoMensual * 12;

    if (sueldoAnual > 416220 && sueldoAnual <= 624329)
    {
        decimal sueldoExcedente = sueldoAnual - 416220;
        impuesto = sueldoExcedente * 0.15m;
    }

    return impuesto;
}
	    
public decimal evaluarSueldo20(decimal sueldoMensual)
{
    decimal impuesto = 0;
    decimal sueldoAnual = sueldoMensual * 12;

    if (sueldoAnual > 624329 && sueldoAnual <= 867123)
    {
        decimal sueldoExcedente = sueldoAnual - 624329;
        impuesto = 31216.00m + sueldoExcedente * 0.20m; 
    }

    return impuesto;
}
	    
        public decimal evaluarSueldo25(decimal sueldoMensual)
        {
            return 0;
        }
    }

	internal class RangoSueldoTipo
    {
        public decimal RangoAnual { get; set; }
        public short Tipo { get; set; }
    }
}
