namespace Memento
{
    internal class Historico
    {
        private IDictionary<DateTime, Estado> estados = new Dictionary<DateTime, Estado>();

        public Estado GetEstado(DateTime data)
        {
            return estados[data];
        }

        public void Adiciona()
    }
}
