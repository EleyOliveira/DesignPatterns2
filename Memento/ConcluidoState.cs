namespace Memento
{
    internal class ConcluidoState : IState
    {
        public IState Proximo { get; set; }
        
        public TipoContrato Avanca(TipoContrato tipo)
        {
            if (tipo == TipoContrato.Acertado)
            {
                return TipoContrato.Concluido;
            }
            else
            {
               return Proximo.Avanca(tipo);   
            }
        }
    }
}
