using ChekpointCP4.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ChekpointCP4.Models.Formas2D
{
    public record Retangulo(
        [Range(0.0000001, double.MaxValue, ErrorMessage = "Largura deve ser positiva.")] 
        double Largura, 
        [Range(0.0000001, double.MaxValue, ErrorMessage = "Altura deve ser positiva.")] 
        double Altura
    ) : ICalculos2D
    {
        public double CalcularArea()
        {
            return Largura * Altura;
        }
        public double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }
    }
}
