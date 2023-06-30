// See https://aka.ms/new-console-template for more information
using Memento;

Console.WriteLine("Hello, World!");

Historico historico = new Historico();

Contrato contrato = new Contrato(DateTime.Now, "Osvaldino do Nascimento");

historico.Adiciona("20/05/2023", contrato.SalvaEstado());

contrato.Avanca();
historico.Adiciona("21/05/2023", contrato.SalvaEstado());

contrato.Avanca();
historico.Adiciona("22/05/2023", contrato.SalvaEstado());

contrato.Avanca();
historico.Adiciona("23/05/2023", contrato.SalvaEstado());

//Estado estado = historico.GetEstado("23/05/2023");

foreach (var estado in historico.GetAll())
{    
    Console.WriteLine($"Cliente: {estado.Value.contrato.Cliente}\nSituação: {estado.Value.contrato.Tipo}\nData: {estado.Value.contrato.Data}");
}

//Console.WriteLine($"Cliente: {estado.contrato.Cliente}\nSituação: {estado.contrato.Tipo}\nData: {estado.contrato.Data}");