using System.Text.Json;
using ScreenSound04.Filtros;
using ScreenSound04.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
 
        //Console.WriteLine(resposta);
        //Console.ReadKey();

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        musicas[1998].ExibirDetalhesDaMusica();
        Console.ReadKey();
        /*
        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        Console.ReadKey();

        LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        Console.ReadKey();

        LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "metal");
        Console.ReadKey();
        */

        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        Console.ReadKey();

        LinqFilter.FiltrarMusicasPeloAno(musicas, 1999);
        Console.ReadKey();


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

    Console.ReadKey();
}