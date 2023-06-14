namespace Memento
{
    internal class EmAndamentoState : IState
    {
        public IState Proximo { get; set; }
        
        public TipoContrato Avanca(TipoContrato tipo)
        {
            if (tipo == TipoContrato.EmAndamento)
            {
                return TipoContrato.Acertado;
            }
            else
            {
               return Proximo.Avanca(tipo);   
            }
        }
    }
}
