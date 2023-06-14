using System.Runtime.Serialization;

namespace Memento
{
    internal interface IState
    {
        TipoContrato Avanca(TipoContrato tipo);
        IState Proximo {get; set;}
    }
}
