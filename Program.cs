using DesafioProjetoHospedagem.Models;



// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome:"Luiz", sobrenome:"Ricardo");
Pessoa p2 = new Pessoa("Maria", "Eduarda");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

foreach(var rolar in hospedes){
    Console.WriteLine($"{rolar.NomeCompleto}");
}

// foreach (var hospede in hospedes)
//             {
//                 Console.WriteLine($"Nome completo: {hospede.NomeCompleto}");
//             }