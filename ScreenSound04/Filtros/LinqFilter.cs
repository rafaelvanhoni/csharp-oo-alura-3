﻿using ScreenSound04.Modelos;

namespace ScreenSound04.Filtros;

internal class LinqFilter
{
	public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
	{
		var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

		foreach(var genero in todosOsGenerosMusicais)
		{
			Console.WriteLine($"- {genero}");
		}
	}
}

