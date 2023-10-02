using System.Text.Json.Serialization;

namespace ScreenSound04.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("year")]
    public string? AnoString { get; set; }

    public int Ano => int.Parse(AnoString!);
    /*
    public int Ano {
        get
        {
            return int.Parse(AnoString!);
        }
    }*/

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"\r\nArtista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração sem segundos: {Duracao / 1000}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Ano: {Ano}");

    }
}

