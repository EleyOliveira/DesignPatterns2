namespace Memento
{
    internal class NovoState : IState
    {
        public IState Proximo { get; set; }
        
        public TipoContrato Avanca(TipoContrato tipo)
        {
            if (tipo == TipoContrato.Novo)
            {
                return TipoContrato.EmAndamento;
            }
            else
            {
               return Proximo.Avanca(tipo);   
            }
        }
    }
}
