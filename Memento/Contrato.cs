using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Contrato
    {
        public DateTime Data { get; private set; }
        public string Cliente { get; private set; }
        public TipoContrato Tipo { get; private set; }

        public Contrato(DateTime data, string cliente, TipoContrato tipo)
        {
            Data = data;
            Cliente = cliente;
            Tipo = tipo;
        }

        public void Avanca()
        {
            if(this.Tipo == TipoContrato.Novo) this.Tipo = TipoContrato.EmAndamento;
            if (this.Tipo == TipoContrato.EmAndamento) this.Tipo = TipoContrato.Acertado;
            if (this.Tipo == TipoContrato.Acertado) this.Tipo = TipoContrato.Concluido;
        }
    }
}
