namespace Flyweight
{
    internal class NotasMusicais
    {
        private static readonly IDictionary<string, INota> notas = new Dictionary<string, INota>()
        {
            { "do", new Do() },
            { "re", new Re() },
            { "mi", new Mi() },
            { "fa", new Fa() },
            { "sol", new Sol() },
            { "la", new La() },
            { "si", new Si() }
        };

        public INota GetNota(string nota)
        {
            return notas[nota];
        }
    }
}
