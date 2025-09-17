namespace ChekpointCP4.Interfaces
{
    public interface ICalculadoraService
    {
        double Area(ICalculos2D f); 
        double Perimetro(ICalculos2D f);
        double Volume(ICalculos3D f); 
        double AreaSuperficial(ICalculos3D f);
    }
}
