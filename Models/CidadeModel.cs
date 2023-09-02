using System.Text.Json.Serialization;

public class CidadeModel{


    [JsonPropertyName("nome")]
    public string? Nome { get; set; }

    [JsonPropertyName("estado")]
    public string? Estado { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    
}




