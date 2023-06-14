namespace Memento
{
    internal class Contrato
    {
        public DateTime Data { get; private set; }
        public string Cliente { get; private set; }
        public TipoContrato Tipo { get; private set; }

        public Contrato(DateTime data, string cliente)
        {            
            Data = data;
            Cliente = cliente;
            Tipo = TipoContrato.Novo;
        }

        private Contrato(DateTime data, string cliente, TipoContrato tipo) 
        { 
            Data = data;
            Cliente = cliente;
            Tipo = tipo;
        }

        public void Avanca()
        {
            Tipo = ConfiguraTipo(this.Tipo);
        }

        public Estado SalvaEstado() 
        {            
            return new Estado(new Contrato(this.Data, this.Cliente, this.Tipo));
        }

        private TipoContrato ConfiguraTipo(TipoContrato tipoContrato)
        {
            IState novo = new NovoState();
            IState emAndamento = new EmAndamentoState();
            IState acertado = new AcertadoState();
            IState concluido = new ConcluidoState();
            novo.Proximo = emAndamento;
            emAndamento.Proximo = acertado;
            acertado.Proximo = concluido;
            return novo.Avanca(tipoContrato);
        }
    }
}
