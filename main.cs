using System;

namespace aula;
class Aula
{
    static void Main()
    {
        Musica letra1 = new Musica("Street of Dreams - Gun's n Roses");
        Guitarra LesPaul = new Guitarra();
        LesPaul.tocarMusica(letra1);
    }
}