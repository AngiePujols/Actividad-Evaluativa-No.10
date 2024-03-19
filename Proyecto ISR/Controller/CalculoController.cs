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
            return 0;
        }
        public decimal evaluarSueldo20(decimal sueldoMensual)
        {
            return 0;
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
