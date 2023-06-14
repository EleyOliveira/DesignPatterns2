namespace Memento
{
    internal class ConfiguraTipo
    {
        public TipoContrato GetTipoContrato(TipoContrato tipoContrato)
        {            
            if (tipoContrato == TipoContrato.Novo) return TipoContrato.EmAndamento;
            else if (tipoContrato == TipoContrato.EmAndamento) return TipoContrato.Acertado;
            else if (tipoContrato == TipoContrato.Acertado) return TipoContrato.Concluido;
            else return tipoContrato;
        }

        public TipoContrato Inicializar()
        {
            return TipoContrato.Novo;
        }
    }
}
