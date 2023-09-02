using System.Text.Json.Serialization;

public class ClimaModel{


    [JsonPropertyName("data")]
        public string? Data { get; set; }

        [JsonPropertyName("condicao")]
        public string? Condicao { get; set; }

        [JsonPropertyName("min")]
        public int? Min { get; set; }

        [JsonPropertyName("max")]
        public int? Max { get; set; }

        [JsonPropertyName("indice_uv")]
        public int? Indice_uv { get; set; }

        [JsonPropertyName("condicao_desc")]
        public string? Condicao_desc { get; set; }
    }

    public class LocalizaModel
    {
        [JsonPropertyName("cidade")]
        public string? Cidade { get; set; }

        [JsonPropertyName("estado")]
        public string? Estado { get; set; }

        [JsonPropertyName("atualizado_em")]
        public string? Atualizado_em { get; set; }

        [JsonPropertyName("clima")]
        public List<ClimaModel>? Clima { get; set; }
    }





