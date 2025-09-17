using ChekpointCP4.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ChekpointCP4.Models.Formas2D
{
    public record Circulo(
        [Range(0.0000001, double.MaxValue, ErrorMessage = "Raio deve ser positivo.")] 
        double Raio
    ) : ICalculos2D
    {
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }
    }
}
