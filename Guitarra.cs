using System;
namespace aula;
public class Guitarra : Instrumento {
    public override void tocarMusica(Musica musica) {
        Console.WriteLine(musica.NomeMusica);
    }
}