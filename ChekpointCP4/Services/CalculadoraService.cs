using ChekpointCP4.Interfaces;

namespace ChekpointCP4.Services
{
    public class CalculadoraService : ICalculadoraService
    {
        public double Area(ICalculos2D f)
        {
            return f.CalcularArea();
        }
        public double Perimetro(ICalculos2D f)
        {
            return f.CalcularPerimetro();
        }
        public double Volume(ICalculos3D f)
        {
            return f.CalcularVolume();
        }
        public double AreaSuperficial(ICalculos3D f)
        {
            return f.CalcularAreaSuperficial();
        }
    }
}
