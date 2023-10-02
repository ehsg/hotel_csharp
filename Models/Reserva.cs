using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace hotel_csharp.Models
{
    public class Reserva
    {
        public Reserva (int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade < hospedes.Count)
            {
                throw new Exception("Capacidade nao comportada. Suite nao comporta a quantidade de pessoas");
            }
            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidade()
        {
            int quantidade = Hospedes.Count;
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            decimal total = Suite.ValorDiaria * DiasReservados;
            return DiasReservados > 9 ?  total * 0.9M : total;
        }
    }
}