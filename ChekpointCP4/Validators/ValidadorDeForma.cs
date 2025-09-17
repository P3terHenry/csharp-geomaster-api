using ChekpointCP4.DTO;
using ChekpointCP4.Interfaces;
using ChekpointCP4.Models.Formas2D;
using ChekpointCP4.Models.Formas3D;

namespace ChekpointCP4.Validators
{
    public class ValidadorDeForma : IValidadorDeForma
    {
        public ErrorResponse? Validar(object forma)
        {
            switch (forma)
            {
                case Circulo c when c.Raio <= 0:
                    return new ErrorResponse { Status = 400, Title = "Validação falhou", Detail = "O raio do círculo deve ser maior que zero." };

                case Retangulo r when r.Largura <= 0 || r.Altura <= 0:
                    return new ErrorResponse { Status = 400, Title = "Validação falhou", Detail = "Largura e/ou Altura do retângulo devem ser maiores que zero." };

                case Esfera e when e.Raio <= 0:
                    return new ErrorResponse { Status = 400, Title = "Validação falhou", Detail = "O raio da esfera deve ser maior que zero." };

                case Circulo or Retangulo or Esfera:
                    return null; 

                default:
                    return new ErrorResponse { Status = 400, Title = "Validação falhou", Detail = "Tipo de forma não reconhecido." };
            }
        }
    }
}
