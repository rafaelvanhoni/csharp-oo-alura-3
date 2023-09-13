using System.Text.Json;
using ScreenSound04.Filtros;
using ScreenSound04.Modelos;

using (HttpClient client = new HttpClient())
{

    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
 
        //Console.WriteLine(resposta);

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[1998].ExibirDetalhesDaMusica();

        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

    Console.ReadKey();

}