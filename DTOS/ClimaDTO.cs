public class ClimaDTO
{
    public string? Data { get; set; }
    public string? Condicao { get; set; }
    public int? Min { get; set; }
    public int? Max { get; set; }
    public int? Indice_uv { get; set; }
    public string? Condicao_desc { get; set; }
}

public class LocalizaDTO
{
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
    public string? Atualizado_em { get; set; }
    public List<ClimaDTO>? Clima { get; set; }
}