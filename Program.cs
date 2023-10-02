using System.Globalization;
using hotel_csharp.Models;

// Cria Hospedes
List<Pessoa> hospedes = new List<Pessoa>();
Pessoa p1 = new Pessoa(nome: "Jonathan", sobrenome: "Silva");
Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "Joasquina");
Pessoa p3 = new Pessoa(nome: "Jorge", sobrenome: "Araujo");
hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

// Cria Suite
Suite suitePremium = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 100);

// Cria Reserva
Reserva reserva = new Reserva(diasReservados: 12);
reserva.CadastrarSuite(suitePremium);
reserva.CadastrarHospedes(hospedes);

// Exibe quantidade hospedes e valor
Console.WriteLine($"Hospedes total: {reserva.ObterQuantidade()}");
Console.WriteLine($"Valor Total diaria: {reserva.CalcularValorDiaria().ToString("C2", CultureInfo.CreateSpecificCulture("pt-BR"))}");
