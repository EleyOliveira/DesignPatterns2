namespace Memento
{
    internal class Historico
    {
        private IDictionary<string, Estado> estados = new Dictionary<string, Estado>();

        public Estado GetEstado(string data)
        {
            return estados[data];
        }

        public void Adiciona(string data, Estado estado)
        {
            estados.Add(data, estado);
        }
    }
}
