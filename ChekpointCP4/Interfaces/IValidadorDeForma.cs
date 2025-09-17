using ChekpointCP4.DTO;

namespace ChekpointCP4.Interfaces
{
    public interface IValidadorDeForma
    {
        ErrorResponse? Validar(object forma);
    }
}
