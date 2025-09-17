using ChekpointCP4.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ChekpointCP4.Models.Formas3D
{
    public record Esfera(
        [Range(0.0000001, double.MaxValue, ErrorMessage = "Raio deve ser positivo.")]
        double Raio
    ) : ICalculos3D
    {
        public double CalcularAreaSuperficial()
        {
            return 4 * Math.PI * Math.Pow(Raio, 2);
        }
        public double CalcularVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Raio, 3);
        }
    }
}
