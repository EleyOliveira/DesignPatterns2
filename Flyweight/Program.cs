// See https://aka.ms/new-console-template for more information
using Flyweight;

Console.WriteLine("Hello, World!");

NotasMusicais notas = new NotasMusicais();

IList<INota> musica = new List<INota>()
{
    notas.GetNota("do"),
    notas.GetNota("re"),
    notas.GetNota("mi"),
    notas.GetNota("fa"),
    notas.GetNota("fa"),
    notas.GetNota("fa")
};

Piano piano = new();
piano.Toca(musica);