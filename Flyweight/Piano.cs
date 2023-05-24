namespace Flyweight
{
    internal class Piano
    {
        public void Toca(IList<INota> notas)
        {
            foreach (INota nota in notas)
            {
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}
