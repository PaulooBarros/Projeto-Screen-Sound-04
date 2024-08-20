using ScreenSoud_04.Modelos;
using System.Linq;
using System.Text.Json;

namespace ScreenSoud_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"-> Genero: {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("Exibindo os Artistas por genero musical");

        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"-> {artista}");
        }   
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string NomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals (NomeDoArtista)).ToList();
        Console.WriteLine(NomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"-> {musica.Nome}");
        }
    }
}
