using System.Text.Json;
namespace ScreenSoud_04.Modelos;

class MusicasPreferidas
{
    public string? Nome { get; set; }

    public List<Musica> listaDeMusicasFavoritas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        listaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        listaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas de {Nome}");
        foreach (var musica in listaDeMusicasFavoritas)
        {
            Console.WriteLine($"\n-> {musica.Nome} de {musica.Artista}");
        }
    }
    
    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = listaDeMusicasFavoritas,

        });
        string nomeDoArquivo = $"Músicas - Favoritas - {Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Json foi criado com sucesso. {Path.GetFullPath(nomeDoArquivo)}");
    }

}
