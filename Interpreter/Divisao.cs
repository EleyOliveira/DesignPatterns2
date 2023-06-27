namespace Interpreter
{
    internal class Divisao : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            if (direita.Avalia() == 0)
            {
                throw new InvalidOperationException("Denominador não pode ser zero");
            }

            return esquerda.Avalia() / direita.Avalia();
        }
    }
}
