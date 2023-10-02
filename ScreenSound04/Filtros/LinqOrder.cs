﻿using ScreenSound04.Modelos;

namespace ScreenSound04.Filtros;

internal class LinqOrder
{

    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine("\r\nLista de artistas ordenados:");

        foreach(var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }

}

