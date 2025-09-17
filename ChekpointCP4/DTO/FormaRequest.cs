namespace ChekpointCP4.DTO
{
    public class FormaRequest
    {
        public string TipoForma { get; set; } = string.Empty;
        public Dictionary<string, double> Propriedades { get; set; } = new();
    }
}
