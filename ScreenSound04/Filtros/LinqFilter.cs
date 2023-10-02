using ScreenSound04.Modelos;

namespace ScreenSound04.Filtros;

internal class LinqFilter
{
	public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
	{
		var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

		Console.WriteLine("\r\nLista de gêneros musicais:");

		foreach (var genero in todosOsGenerosMusicais)
		{
			Console.WriteLine($"- {genero}");
		}
	}

	public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
	{
		var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
		Console.WriteLine($"\r\nExibindo artistas por gênero musical >>> gênero {genero}");

        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }

    }

	public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
	{

		var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
		Console.WriteLine($"\r\nExibindo músicas do artista {nomeDoArtista}");
		foreach (var musica in musicasDoArtista)
		{
            Console.WriteLine($"- {musica.Nome}");
		}

	}

	public static void FiltrarMusicasPeloAno(List<Musica> musicas, int ano)
	{
		var musicasDoAno = musicas.Where(musica => musica.Ano == ano).OrderBy(musicas => musicas.Nome).Select(musicas => musicas.Nome).Distinct().ToList();
		Console.WriteLine($"\r\nExibindo musicas do ano {ano}");
		foreach(var musica in musicasDoAno)
		{
			Console.WriteLine($"- {musica}");
		}
			
	}
}

