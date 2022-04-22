using System;
namespace aula;
public class Guitarra : Instrumento {
    public void tocarMusica(Musica musica) {
        System.Console.WriteLine(musica.NomeMusica);
    }
}