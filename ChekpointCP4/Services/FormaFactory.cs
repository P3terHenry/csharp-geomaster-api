using ChekpointCP4.Models.Formas2D;
using ChekpointCP4.Models.Formas3D;
using System.Text.Json;

namespace ChekpointCP4.Services
{
    public static class FormaFactory
    {
        private static readonly Dictionary<string, Func<JsonElement, object>> map = new(StringComparer.OrdinalIgnoreCase)
        {
            ["circulo"] = d => new Circulo(d.GetProperty("raio").GetDouble()),
            ["retangulo"] = d => new Retangulo(d.GetProperty("largura").GetDouble(), d.GetProperty("altura").GetDouble()),
            ["esfera"] = d => new Esfera(d.GetProperty("raio").GetDouble())
        };

        public static bool TryCreate(string tipoForma, JsonElement propriedades, out object? forma)
        { 
            if (map.TryGetValue(tipoForma, out var f)) 
            { 
                forma = f(propriedades); 
                return true; 
            } 
            forma = null; 
            return false; 
        }
    }
}
