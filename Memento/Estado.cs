namespace Memento
{
    internal class Estado
    {
        public Contrato contrato { get; private set; }

        private DateTime Data;

        public Estado(Contrato contrato)
        {
            this.contrato = contrato;
            this.Data = DateTime.Now;
        }
    }
}
