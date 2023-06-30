namespace Interpreter
{
    internal class Multiplicacao : IExpressao
    {        
        private IExpressao esquerda;
        private IExpressao direita;

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            return esquerda.Avalia() * direita.Avalia();
        }
    }
}
