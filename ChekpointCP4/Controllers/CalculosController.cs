using ChekpointCP4.DTO;
using ChekpointCP4.Interfaces;
using ChekpointCP4.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ChekpointCP4.Controllers
{
    [ApiController]
    [Route("api/v1/calculos")]
    [Produces("application/json")]
    public class CalculosController : ControllerBase
    {
        private readonly ICalculadoraService _svc;
        private readonly IValidadorDeForma _validador;

        public CalculosController(ICalculadoraService svc, IValidadorDeForma validador)
        {
            _svc = svc;
            _validador = validador;
        }

        /// <summary>Calcula a área de uma forma 2D.</summary>
        /// <remarks>
        /// Exemplo de requisição:
        /// 
        /// Círculo:
        /// ```json
        /// {
        ///   "tipoForma": "circulo",
        ///   "propriedades": { 
        ///     "raio": 5 
        ///   }
        /// }
        /// ```
        ///
        /// Retângulo:
        /// ```json
        /// {
        ///   "tipoForma": "retangulo",
        ///   "propriedades": { 
        ///     "largura": 3, 
        ///     "altura": 4 
        ///   }
        /// }
        /// ```
        /// </remarks>
        /// <response code="200">Retorna o resultado da área.</response>
        /// <response code="400">Quando a forma é inválida.</response>
        [HttpPost("area")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(double))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        public ActionResult<double> Area([FromBody] FormaRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.TipoForma))
                return BadRequest(new ErrorResponse { Status = 400, Title = "Requisição inválida", Detail = "Campo 'tipoForma' é obrigatório." });

            var json = JsonSerializer.SerializeToElement(request.Propriedades);

            if (!FormaFactory.TryCreate(request.TipoForma, json, out var forma) || forma is not ICalculos2D f2d)
                return BadRequest(new ErrorResponse { Status = 400, Title = "Forma inválida", Detail = "A forma enviada não é válida para cálculo de área 2D." });

            var erro = _validador.Validar(f2d);
            if (erro != null) return BadRequest(erro);

            return Ok(_svc.Area(f2d));
        }

        /// <summary>Calcula o perímetro de uma forma 2D.</summary>
        /// <remarks>
        /// Exemplo:
        /// ```json
        /// {
        ///   "tipoForma": "retangulo",
        ///   "propriedades": { 
        ///     "largura": 3, 
        ///     "altura": 4 
        ///   }
        /// }
        /// ```
        /// </remarks>
        [HttpPost("perimetro")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(double))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        public ActionResult<double> Perimetro([FromBody] FormaRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.TipoForma))
                return BadRequest(new ErrorResponse { Status = 400, Title = "Requisição inválida", Detail = "Campo 'tipoForma' é obrigatório." });

            var json = JsonSerializer.SerializeToElement(request.Propriedades);

            if (!FormaFactory.TryCreate(request.TipoForma, json, out var forma) || forma is not ICalculos2D f2d)
                return BadRequest(new ErrorResponse { Status = 400, Title = "Forma inválida", Detail = "A forma enviada não é válida para cálculo de perímetro." });

            var erro = _validador.Validar(f2d);
            if (erro != null) return BadRequest(erro);

            return Ok(_svc.Perimetro(f2d));
        }

        /// <summary>Calcula o volume de uma forma 3D.</summary>
        /// <remarks>
        /// Exemplo:
        /// ```json
        /// {
        ///   "tipoForma": "esfera",
        ///   "propriedades": { 
        ///     "raio": 2 
        ///   }
        /// }
        /// ```
        /// </remarks>
        [HttpPost("volume")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(double))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        public ActionResult<double> Volume([FromBody] FormaRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.TipoForma))
                return BadRequest(new ErrorResponse { Status = 400, Title = "Requisição inválida", Detail = "Campo 'tipoForma' é obrigatório." });

            var json = JsonSerializer.SerializeToElement(request.Propriedades);

            if (!FormaFactory.TryCreate(request.TipoForma, json, out var forma) || forma is not ICalculos3D f3d)
                return BadRequest(new ErrorResponse { Status = 400, Title = "Forma inválida", Detail = "A forma enviada não é válida para cálculo de volume." });

            var erro = _validador.Validar(f3d);
            if (erro != null) return BadRequest(erro);

            return Ok(_svc.Volume(f3d));
        }

        /// <summary>Calcula a área superficial de uma forma 3D.</summary>
        /// <remarks>
        /// Exemplo:
        /// ```json
        /// {
        ///   "tipoForma": "esfera",
        ///   "propriedades": { 
        ///     "raio": 3 
        ///   }
        /// }
        /// ```
        /// </remarks>
        [HttpPost("area-superficial")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(double))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        public ActionResult<double> AreaSuperficial([FromBody] FormaRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.TipoForma))
                return BadRequest(new ErrorResponse { Status = 400, Title = "Requisição inválida", Detail = "Campo 'tipoForma' é obrigatório." });

            var json = JsonSerializer.SerializeToElement(request.Propriedades);

            if (!FormaFactory.TryCreate(request.TipoForma, json, out var forma) || forma is not ICalculos3D f3d)
                return BadRequest(new ErrorResponse { Status = 400, Title = "Forma inválida", Detail = "A forma enviada não é válida para cálculo de área superficial." });

            var erro = _validador.Validar(f3d);
            if (erro != null) return BadRequest(erro);

            return Ok(_svc.AreaSuperficial(f3d));
        }
    }
}
