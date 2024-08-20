using ScreenSoud_04.Modelos;
using System.Net.Http.Json;
using System.Text.Json;
using ScreenSoud_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta); // Print the response to check the content.
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "XXXTENTACION");


        //var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[546]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[971]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1078]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1634]);

        //musicasPreferidasDoDaniel.ExibirMusicasFavoritas();


        //var musicasPreferidasDeGustavo = new MusicasPreferidas("Gustavo");
        //musicasPreferidasDeGustavo.AdicionarMusicasFavoritas(musicas[1998]);
        //musicasPreferidasDeGustavo.AdicionarMusicasFavoritas(musicas[1996]);
        //musicasPreferidasDeGustavo.AdicionarMusicasFavoritas(musicas[1995]);
        //musicasPreferidasDeGustavo.AdicionarMusicasFavoritas(musicas[1994]);
        //musicasPreferidasDeGustavo.AdicionarMusicasFavoritas(musicas[1997]);
        
        //musicasPreferidasDeGustavo.ExibirMusicasFavoritas();    

        //musicasPreferidasDeGustavo.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
} 



